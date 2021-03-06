using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Threading;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Utils.Drawing;
using System.Linq;

namespace ManagementSASI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            InitSkinGallery();
            frmSplash f = new frmSplash();
            f.Show();
            System.Threading.Thread.Sleep(2000);
            f.Close();

           
        }
        ManagementSASIDataContext db = new ManagementSASIDataContext();
      
        Thread thread;
        public static bool testlogin = false;
        public static string username = string.Empty;
        TestManageSASI testmana = new TestManageSASI();
        private void btnClass_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
               
                testmana.ShowfrmClass();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa kết nối thành công kết nối lại .\n" + ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmConfiguration t = new frmConfiguration();
                t.ShowDialog();
            }
        }
      
        private void LoadDocument(string fileName)
        {
            
        }
     
        void InitSkinGallery()
        {
            SimpleButton imageButton = new SimpleButton();
            foreach (SkinContainer cnt in SkinManager.Default.Skins)
            {
                imageButton.LookAndFeel.SetSkinStyle(cnt.SkinName);
                GalleryItem gItem = new GalleryItem();
                int groupIndex = 0;
                if (cnt.SkinName.IndexOf("Office") > -1) groupIndex = 1;
                rgbiSkins.Gallery.Groups[groupIndex].Items.Add(gItem);
                gItem.Caption = cnt.SkinName;

                gItem.Image = GetSkinImage(imageButton, 32, 17, 2);
                gItem.HoverImage = GetSkinImage(imageButton, 70, 36, 5);
                gItem.Caption = cnt.SkinName;
                gItem.Hint = cnt.SkinName;
                rgbiSkins.Gallery.Groups[1].Visible = false;
            }
        }
        Bitmap GetSkinImage(SimpleButton button, int width, int height, int indent)
        {
            Bitmap image = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(image))
            {
                StyleObjectInfoArgs info = new StyleObjectInfoArgs(new GraphicsCache(g));
                info.Bounds = new Rectangle(0, 0, width, height);
                button.LookAndFeel.Painter.GroupPanel.DrawObject(info);
                button.LookAndFeel.Painter.Border.DrawObject(info);
                info.Bounds = new Rectangle(indent, indent, width - indent * 2, height - indent * 2);
                button.LookAndFeel.Painter.Button.DrawObject(info);
            }
            return image;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

            if (testlogin)
            {
                lblComputer.Caption = "Tên máy : " + SystemInformation.ComputerName;
             
            }
            else
            {
                frmLogin frmlogin = new frmLogin();
                frmlogin.ShowDialog();
            }

        }

        void OnPaintStyleClick(object sender, ItemClickEventArgs e)
        {
            defaultLookAndFeel1.LookAndFeel.SetSkinStyle(e.Item.Tag.ToString());
        }


        private void btnSubject_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmSubject t = new frmSubject();
                t.ShowDialog();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa kết nối thành công kết nối lại .\n" + ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmConfiguration t = new frmConfiguration();
                t.ShowDialog();
            }
        }

        private void btnteacher_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmTeacher frmteacher = new frmTeacher();
                frmteacher.ShowDialog();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa kết nối thành công kết nối lại .\n" + ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmConfiguration t = new frmConfiguration();
                t.ShowDialog();
            }
        }

        private void btnTrain_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmTrain t = new frmTrain();
                t.ShowDialog();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa kết nối thành công kết nối lại .\n" + ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmConfiguration t = new frmConfiguration();
                t.ShowDialog();
            }
        }


        private void bbtnStudentToRegistry_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmStudentToRegistry();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa kết nối thành công kết nối lại .\n" + ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmConfiguration t = new frmConfiguration();
                t.ShowDialog();
            }
        }

        private void frmStudentToRegistry()
        {
            try
            {
                testmana.ShowfrmStudentToRegisTer();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa kết nối thành công kết nối lại .\n" + ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmConfiguration t = new frmConfiguration();
                t.ShowDialog();
            }
        }
        private void btnSASIStudentID_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa kết nối thành công kết nối lại .\n" + ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmConfiguration t = new frmConfiguration();
                t.ShowDialog();
            }
        }

        private void bbtnChangePassWord_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmChangePassword t = new frmChangePassword();
                t.ShowDialog();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa kết nối thành công kết nối lại .\n" + ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmConfiguration t = new frmConfiguration();
                t.ShowDialog();
            }
        }

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", Application.ProductName.ToString(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.Hide();
                frmLogin t = new frmLogin();
                t.ShowDialog();
               
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa kết nối thành công kết nối lại .\n" + ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmConfiguration t = new frmConfiguration();
                t.ShowDialog();
            }
        }

        private void btnListStudentMoneySI_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmListStudentMoneySI t = new frmListStudentMoneySI();
            t.ShowDialog();
        }
        frmWatingServer frmw = new frmWatingServer();
        private void Waiting()
        {
            frmw.ShowDialog();
        }
        private void LoadListStudentMoneySI()
        {
            thread = new Thread(new ThreadStart(Waiting));
            thread.Start();
            frmListStudentMoneySI frmlist = new frmListStudentMoneySI();
            frmlist.ShowDialog();
            frmw.Close();
            thread.Abort();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                timer1.Interval = 100;
                timer1.Enabled = true;
            }
            catch { }
        }

        private void btnGeneraMoneySASITeacher_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmListGeneraMoneySASITeacher t = new frmListGeneraMoneySASITeacher();
            t.ShowDialog();
        }

        private void btnListStudentMoneySI_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            frmListStudentMoneySI t = new frmListStudentMoneySI();
            t.ShowDialog();
        }

        private void btnGeneraMoneySASIClass_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmListGeneraMoneySASIClass t = new frmListGeneraMoneySASIClass();
            t.ShowDialog();
        }

        private void rgbiSkins_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void rgbiSkins_GalleryInitDropDownGallery(object sender, InplaceGalleryEventArgs e)
        {
         
        }

        private void rgbiSkins_Gallery_ItemClick(object sender, GalleryItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(e.Item.Caption);
        }

        private void rgbiSkins_Gallery_InitDropDownGallery(object sender, InplaceGalleryEventArgs e)
        {
            e.PopupGallery.CreateFrom(rgbiSkins.Gallery);
            e.PopupGallery.AllowFilter = false;
            e.PopupGallery.ShowItemText = true;
            e.PopupGallery.ShowGroupCaption = true;
            e.PopupGallery.AllowHoverImages = false;
            foreach (GalleryItemGroup galleryGroup in e.PopupGallery.Groups)
                foreach (GalleryItem item in galleryGroup.Items)
                    item.Image = item.HoverImage;
            e.PopupGallery.ColumnCount = 2;
            e.PopupGallery.ImageSize = new Size(70, 36);
        }

        private void btnBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBackup t = new frmBackup();
            t.ShowDialog();
        }

        private void btnRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmRestore t = new frmRestore();
            t.ShowDialog();
        }

        private void nbiRegistryToStudent_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmStudentToRegistry();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmListGeneraMoneySASITeacher t = new frmListGeneraMoneySASITeacher();
            t.ShowDialog();
        }

        private void nbiToSubject_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmListStudentMoneySI t = new frmListStudentMoneySI();
            t.ShowDialog();
        }

        private void nbiToClass_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmListGeneraMoneySASIClass t = new frmListGeneraMoneySASIClass();
            t.ShowDialog();
        }


        private void btnTakeExamSASI_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmListTakeATestSASI t = new frmListTakeATestSASI();
                t.ShowDialog();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa kết nối thành công kết nối lại .\n" + ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmConfiguration t = new frmConfiguration();
                t.ShowDialog();
            }
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmDepartment t = new frmDepartment();
                t.ShowDialog();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa kết nối thành công kết nối lại .\n" + ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmConfiguration t = new frmConfiguration();
                t.ShowDialog();
            }
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                frmListTakeATestSASI t = new frmListTakeATestSASI();
                t.ShowDialog();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa kết nối thành công kết nối lại .\n" + ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmConfiguration t = new frmConfiguration();
                t.ShowDialog();
            }
        }

        private void btnTrain_Subject_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmTrain_Subject t = new frmTrain_Subject();
                t.ShowDialog();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa kết nối thành công kết nối lại .\n" + ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmConfiguration t = new frmConfiguration();
                t.ShowDialog();
            }
        }

        private void btnSASIClass_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmStudentToRegisters frmstr = new frmStudentToRegisters();
                frmstr.Close();

                testmana.ShowfrmSASIClass();

            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa kết nối thành công kết nối lại .\n" + ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmConfiguration t = new frmConfiguration();
                t.ShowDialog();
            }
        }

        private void nbiSASIClass_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                frmStudentToRegisters frmstr = new frmStudentToRegisters();
                frmstr.Close();
                
                testmana.ShowfrmSASIClass();

            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa kết nối thành công kết nối lại .\n" + ex.Message, Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmConfiguration t = new frmConfiguration();
                t.ShowDialog();
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmListStudentToClass t = new frmListStudentToClass();
            t.ShowDialog();
        }

        private void btnTestNotClass_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTestClassSASINotYet t = new frmTestClassSASINotYet();
            t.ShowDialog();
        }

        private void nbiStudentToClass_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmListStudentToClass t = new frmListStudentToClass();
            t.ShowDialog();
        }

        private void bbiServer_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmConfiguration f = new frmConfiguration();
            f.ShowDialog();
        }

        private void bbiSettingMoney_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmConfig t = new frmConfig();
            t.ShowDialog();
        }

        private void bbiGeneralRecipt_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmListGeneralReceiptMoney t = new frmListGeneralReceiptMoney();
            t.ShowDialog();
        }

        private void bbiSASIClassEnd_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSASIClassEnd t = new frmSASIClassEnd();
            t.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmListMoneySASI frm = new frmListMoneySASI();
            frm.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmRetestList frm = new frmRetestList();
            frm.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTrainingInformation frm = new frmTrainingInformation();
            frm.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSettingSubjectSplit frm = new frmSettingSubjectSplit();
            frm.ShowDialog();
        }

        private void bbiSASIClassesEnd_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSASIClassEnd t = new frmSASIClassEnd();
            t.ShowDialog();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmListGeneraMoneySASITeacher frm = new frmListGeneraMoneySASITeacher();
            frm.ShowDialog();
        }

        private void bbiStudentToRegistry_ItemClick(object sender, ItemClickEventArgs e)
        {
            testmana.ShowfrmStudentToRegisTer();
        }

        private void bbiStudent_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStudent frm = new frmStudent();
            frm.ShowDialog();
        }



      

    }
}