using cnPublic4;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using UserClass4;

namespace CheckPass
{

    public partial class PASS : Form
    {
        private MsSql condb = null;
        private BackgroundWorker backWorker = null;
        private DataTable dtQry = null;
        private string strBusinessGroup = "";
        public PASS()
        {
            InitializeComponent();
        }

        private void TbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtSearch_Click(object sender, EventArgs e)
        {
            getDataSource();
            

        }
        public static string DecryptDES(string decryptString, string decryptKey)
        {
            //默認密鑰向量
            byte[] Keys = { 0xEF, 0xAB, 0x56, 0x78, 0x90, 0x34, 0xCD, 0x12 };
            DESCryptoServiceProvider DCSP = null;
            MemoryStream mStream = null;
            CryptoStream cStream = null;
            try
            {
                string decryptkey = (decryptKey.Length >= 8 ? decryptKey : decryptKey + "98765432");
                byte[] rgbKey = Encoding.UTF8.GetBytes(decryptkey.Substring(0, 8));
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Convert.FromBase64String(decryptString);
                DCSP = new DESCryptoServiceProvider();
                mStream = new MemoryStream();
                cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                string strdecdes = Encoding.UTF8.GetString(mStream.ToArray());
                mStream.Close();
                DCSP.Clear();
                cStream.Close();

                mStream.Dispose();
                DCSP.Dispose();
                cStream.Dispose();

                return strdecdes;
            }
            catch
            {
                if (mStream != null)
                {
                    mStream.Close();
                    mStream.Dispose();
                }
                if (DCSP != null)
                {
                    DCSP.Clear();
                    DCSP.Dispose();
                }
                if (cStream != null)
                {
                    cStream.Close();
                    cStream.Dispose();
                }

                return decryptString;
            }
        }
        public static string EncryptDES(string plainText, string encryptKey)
        {
            // Default initialization vector
            byte[] keys = { 0xEF, 0xAB, 0x56, 0x78, 0x90, 0x34, 0xCD, 0x12 };
            DESCryptoServiceProvider dcsp = null;
            MemoryStream mStream = null;
            CryptoStream cStream = null;
            try
            {
                string encryptKeyPadded = (encryptKey.Length >= 8 ? encryptKey : encryptKey + "98765432");
                byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKeyPadded.Substring(0, 8));
                byte[] rgbIV = keys;
                byte[] inputByteArray = Encoding.UTF8.GetBytes(plainText);

                dcsp = new DESCryptoServiceProvider();
                mStream = new MemoryStream();
                cStream = new CryptoStream(mStream, dcsp.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                byte[] encryptedBytes = mStream.ToArray();

                return Convert.ToBase64String(encryptedBytes);
            }
            finally
            {
                if (mStream != null)
                {
                    mStream.Close();
                    mStream.Dispose();
                }
                if (dcsp != null)
                {
                    dcsp.Clear();
                    dcsp.Dispose();
                }
                if (cStream != null)
                {
                    cStream.Close();
                    cStream.Dispose();
                }
            }
        }
        private void BtEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbGroup_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TbPassWord.Text = "";
            TbUserName.Text = "";
            TbUserCode.Text = "";
            TbPhone.Text = "";
            strBusinessGroup = CbGroup.SelectedValue.ToString();
        }
        private void LoadGroup()
        {
            SetDataBase();
            try
            {
                DataTable dtResult = condb.createDataTable("group", "select * from businessgroup");
                if (dtResult.Rows.Count > 0)
                {
                    CbGroup.DataSource = dtResult;
                    DataRow dr = dtResult.NewRow();
                    dr["businessgroupnameen"] = "";
                    dtResult.Rows.InsertAt(dr, 0);
                    CbGroup.ValueMember = "businessgroupnameen";
                    CbGroup.DisplayMember = "businessgroupnameen";
                    CbGroup.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No Data Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                condb.DisConnect();
            }
        }
        private void SetDataBase()
        {
            if (CkDatabaseNow.Checked)
            {
                condb = new MsSql("HUYNHPRO", "A27N6");
            }
            condb = new MsSql("HUYNHPRO", "A27N6_YESTERDAY");
        }

        private void PASS_Load(object sender, EventArgs e)
        {
            LoadGroup();
        }

        private void BtPrt_Click(object sender, EventArgs e)
        {
            try
            {
                
                if(DgMain.Rows.Count > 0)
                {
                    string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    if (!Directory.Exists(pathDesktop + "\\UserPass"))
                    {
                        Directory.CreateDirectory(pathDesktop + "\\UserPass");
                    }
                    string dateTime = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
                    string fileName = pathDesktop + "\\UserPass\\" + dateTime + ".xlsx";
                    OfficeOP4.ExcelOP.SaveToExcel(DgMain, fileName);
                    OfficeOP4.ExcelOP.showExcelFile(fileName);
                }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtCopyPass_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TbPassWord.Text))
            {
                Clipboard.SetText(TbPassWord.Text);
                MessageBox.Show("Copy Success", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Data", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            TbUserName.Text = "";
            TbUserCode.Text = "";
            TbPassWord.Text = "";
            TbPhone.Text = "";
            CbGroup.SelectedIndex = 0;
        }

        private void DgMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DgMain.Rows[e.RowIndex];
                TbUserName.Text = row.Cells["username"].Value.ToString();
                TbUserCode.Text = row.Cells["usercode"].Value.ToString();
                TbPassWord.Text = row.Cells["password"].Value.ToString();
                TbPhone.Text = row.Cells["phone"].Value.ToString();
                CbGroup.SelectedValue = row.Cells["businessgroup"].Value.ToString();
            }
        }
        public void getDataSource()
        {
            FmPublic4.Worker work = FmPublic4.Worker.createWorker(out backWorker, getDataSource2, cnPublic.getMessage("出庫單資料查詢"));
            work.doWork(dtQry);
            if (dtQry.Rows.Count > 0)
            {
                TbUserName.Text = dtQry.Rows[0]["username"].ToString();
                TbUserCode.Text = dtQry.Rows[0]["usercode"].ToString();
                TbPassWord.Text = dtQry.Rows[0]["password"].ToString();
                TbPhone.Text = dtQry.Rows[0]["phone"].ToString();
                DgMain.DataSource = dtQry;
                UpdateCbGroup(dtQry.Rows[0]["businessgroup"].ToString());
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            if (DgMain.Rows.Count == 0)
                cnPublic.showMessage(string.Format("{0}！", "查無符合資料"), "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }
        private void UpdateCbGroup(string value)
        {
            if (CbGroup.InvokeRequired)
            {
                CbGroup.Invoke(new Action<string>(UpdateCbGroup), value);
            }
            else
            {
                CbGroup.SelectedValue = value;
            }
        }
        private void getDataSource2(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (backWorker != null)
                    backWorker.ReportProgress(0, cnPublic.getMessage("資料處理中，請稍後"));
                SetDataBase();
                try
                {
                    string strsql = @"
                    SELECT
                    su.usercode,
                    su.username,
                    su.mypassword as password,
                    su.extension as phone,
                    bg.businessgroupnameen as businessgroup
                    FROM systemuser su
                    LEFT JOIN businessgroup bg WITH (NOLOCK) ON su.businessgroupid = bg.businessgroupid
                    WHERE 1=1";
                    if (TbUserName.Text != "")
                    {
                        strsql += " and username like '%" + TbUserName.Text + "%'";
                    }
                    if (TbUserCode.Text != "")
                    {
                        strsql += " and (usercode like '%" + TbUserCode.Text + "%' or userid like '%" + TbUserCode.Text + "%')";
                    }
                    if (strBusinessGroup != "")
                    {
                        strsql += " and bg.businessgroupnameen like '%" + strBusinessGroup + "%'";
                    }
                    DataTable dtResult = condb.createDataTable("user", strsql);
                    for (int i = 0; i < dtResult.Rows.Count; i++)
                    {
                        if (dtResult.Rows[i]["password"].ToString() != "")
                        {
                            dtResult.Rows[i]["password"] = DecryptDES(dtResult.Rows[i]["password"].ToString(), "");
                        }
                    }
                    dtQry = dtResult;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    condb.DisConnect();
                }
            }
            catch (Exception ex)
            {
                cnPublic.showMessage(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
