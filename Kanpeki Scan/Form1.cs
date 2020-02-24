using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanpeki_Scan
{
    public partial class Form1 : Form
    {
        private Language lang = new Language();
        TwainDotNet.WinFroms.WinFormsWindowMessageHook msgHook;
        TwainDotNet.Twain twain;
        TwainDotNet.ScanSettings settings;
        private bool saved = true;
        public Form1()
        {
            InitializeComponent();
            msgHook = new TwainDotNet.WinFroms.WinFormsWindowMessageHook(this);
            twain = new TwainDotNet.Twain(msgHook);
            settings = new TwainDotNet.ScanSettings();
            cmbScanSouces.Items.Clear();
            twain.SourceNames.ToList().ForEach(src => cmbScanSouces.Items.Add(src));

            twain.ScanningComplete += twain_ScanningComplete;
            twain.TransferImage += twain_TransferImage;

            if (cmbScanSouces.Items.Count > 0)
                cmbScanSouces.SelectedIndex = 0;
            //Image img;
            //img.Save("", System.Drawing.Imaging.ImageFormat.)

            foreach (var item in Enum.GetValues(typeof(OutputFileTypes)))
            {
                cmbOutputFileType.Items.Add(item.ToString());
            }
            cmbOutputFileType.SelectedIndex = Properties.Settings.Default.LastOutputType;
            this.Icon = Properties.Resources.ScanIcon;
            btnScan.Enabled = cmbScanSouces.Items.Count > 0;
            LoadLanguages();


            LoadLanguage();
            UpdateSetDPIMenuItems();
        }

        private void LoadLanguages()
        {
            var languageFiles = System.IO.Directory.GetFiles("languages", "*.xml");
            if (languageFiles.Length == 0)
            {
                System.IO.File.WriteAllText(@"languages\english.xml", Properties.Resources.english);
                LoadLanguages();
                return;
            }
            mnuChangeLanguage.DropDownItems.Clear();
            foreach (var file in languageFiles)
            {
                var tmpLang = Language.Deserialize(file);
                var mnuNew = new ToolStripMenuItem(string.Format("{0} ({1})", tmpLang.LangName, tmpLang.LangType));

                mnuNew.CheckedChanged += ChangeLanguage_CheckedChanged;
                mnuNew.CheckOnClick = true;

                mnuNew.Tag = string.Format(@"Languages\{0}", System.IO.Path.GetFileName(file));
                if ((string)mnuNew.Tag == string.Format(@"Languages\{0}", Properties.Settings.Default.LanguageFile))
                    mnuNew.Checked = true;

                mnuChangeLanguage.DropDownItems.Add(mnuNew);
            }
        }
        private void ChangeLanguage_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem mnu = (ToolStripMenuItem)sender;

            if (mnu.Checked)
            {
                Properties.Settings.Default.LanguageFile = System.IO.Path.GetFileName((string)mnu.Tag);
                LoadLanguage();
                foreach (ToolStripMenuItem item in mnuChangeLanguage.DropDownItems)
                {
                    if (item == mnu) continue;
                    item.Checked = false;
                }
            }
        }


        private void LoadLanguage()
        {
            var file = string.Format(@"Languages\{0}", Properties.Settings.Default.LanguageFile);
            if (!System.IO.File.Exists(file))
            {
                MessageBox.Show("Language file not found.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            lang = Language.Deserialize(file);
            lang.SetText(lblDescription);
            lang.SetText(lblOutputFileType);
            lang.SetText(lblScanSources);
            lang.SetText(lblTargetDirectory);
            lang.SetText(btnBrowse);
            lang.SetText(btnClear);
            lang.SetText(btnSave);
            lang.SetText(btnScan);

            mnuTools.Text = lang.mnuTools;
            mnuExportEmptyLanguageFile.Text = lang.mnuExportEmptyLanguageFile;
            mnuImportLanguageFile.Text = lang.mnuImportLanguageFile;
            mnuChangeDPI.Text = lang.mnuChangeDPI;

            mnuChangeLanguage.Text = lang.mnuChangeLanguage;
            mnuAbout.Text = lang.mnuAbout;
            mnuHelp.Text = lang.mnuHelp;


            foreach (ListViewItem item in lvwPages.Items)
            {
                item.Text = string.Format("{0} {1}", lang.msgPage, item.Index + 1);
            }
        }
        enum OutputFileTypes
        {

            PDF,

            PNG,

            JPG,

            GIF,
        }
        private void button1_Click(object sender, EventArgs e)
        {
            settings.AbortWhenNoPaperDetectable = false;

            settings.Page = new TwainDotNet.PageSettings();
            settings.Page.Orientation = TwainDotNet.TwainNative.Orientation.Portrait;
            settings.Page.Size = TwainDotNet.TwainNative.PageType.A4;

            settings.Resolution = new TwainDotNet.ResolutionSettings();
            settings.Resolution.ColourSetting = TwainDotNet.ColourSetting.Colour;
            settings.Resolution.Dpi = Properties.Settings.Default.DPI;

            //settings.Rotation = new TwainDotNet.RotationSettings();

            //settings.UseAutoFeeder = false;

            settings.UseAutoScanCache = false;

            //settings.UseDocumentFeeder = false;

            settings.UseDuplex = false;

            //settings.Area = new TwainDotNet.AreaSettings(TwainDotNet.TwainNative.Units.Centimeters, 0, 0, 290, 210);

            //settings.ShowTwainUI = true;

            //settings.ShowProgressIndicatorUI = true;



            try
            {
                
                twain.StartScanning(settings);
            saved = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void twain_TransferImage(object sender, TwainDotNet.TransferImageEventArgs e)
        {
            imgListLarge.Images.Add(e.Image);
            var lvi = lvwPages.Items.Add(string.Format("{0} {1}", lang.msgPage, lvwPages.Items.Count + 1), lvwPages.Items.Count);
            lvi.Tag = e.Image;
            lvi.Selected = true;
            lvi.Focused = true;
            lvi.EnsureVisible();
            e.ContinueScanning = false;
        }


        private void twain_ScanningComplete(object sender, TwainDotNet.ScanningCompleteEventArgs e)
        {
            if (e.Exception != null)
            {
                MessageBox.Show(e.Exception.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void cmbScanSouces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbScanSouces.SelectedIndex >= 0)
            {
                try
                {
                    twain.SelectSource(cmbScanSouces.Text);
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTargetDirectory.Text))
            {
                MessageBox.Show(lang.msgTargetDirectoryNotSet, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Focus();
                return;
            }
            else if (!System.IO.Directory.Exists(txtTargetDirectory.Text))
            {
                MessageBox.Show(lang.msgTargetDirectoryNotExist, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show(lang.msgDescriptionNotDefined, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Focus();
                return;
            }
            else if (lvwPages.Items.Count == 0)
            {
                MessageBox.Show(lang.msgNoScannedPagesToSave, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (cmbOutputFileType.SelectedIndex < 0)
            {
                MessageBox.Show(lang.msgOutputFileTypeNotDefined, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SaveFile(txtTargetDirectory.Text, (OutputFileTypes)cmbOutputFileType.SelectedIndex);
        }

        private void SaveFile(string directoryath, OutputFileTypes outputFileType)
        {
            string basePath = string.Format(@"{0}\{1}", directoryath, txtDescription.Text);
            string fullPath = null;
            int n = 0;
            //bool result = true;
            try
            {
                switch (outputFileType)
                {
                    case OutputFileTypes.PDF:
                        fullPath = string.Format(@"{0}.{1}", basePath, outputFileType.ToString());
                        n = 0;
                        while (System.IO.File.Exists(fullPath))
                        {
                            n++;
                            fullPath = string.Format(@"{0} {1}.{2}", basePath, n.ToString("000"), outputFileType.ToString());
                        }
                        PdfSharp.Pdf.PdfDocument doc = new PdfSharp.Pdf.PdfDocument();
                        //doc.Options.CompressContentStreams = true;

                        n = 1;
                        foreach (ListViewItem item in lvwPages.Items)
                        {
                            Image img = (Image)item.Tag;

                            var page = doc.AddPage();
                            var xg = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                            //page.Elements.Add(string.Format("Page {0}", n), new PdfSharp.Pdf.pdf)
                            //Bitmap pdfImg = new Bitmap(page.Width, page.Height);
                            xg.DrawImage(PdfSharp.Drawing.XImage.FromGdiPlusImage(img), 0, 0);

                        }
                        doc.Save(fullPath);
                        MessageBox.Show(string.Format(lang.msgSuccessSaveSingleFile, System.IO.Path.GetFileNameWithoutExtension(fullPath)), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ProcessStartInfo pi = new ProcessStartInfo(fullPath);
                        Process.Start(pi);
                        break;
                    case OutputFileTypes.PNG:
                        SaveImage(basePath, outputFileType, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case OutputFileTypes.JPG:
                        SaveImage(basePath, outputFileType, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case OutputFileTypes.GIF:
                        SaveImage(basePath, outputFileType, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    default:
                        break;
                }
                saved = true;
            }
            catch (Exception ex)
            {
                //result = false;
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveImage(string basePath, OutputFileTypes outputFileType, System.Drawing.Imaging.ImageFormat imageFormat)
        {
            string fullPath = string.Format(@"{0}.{1}", basePath, outputFileType.ToString());
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
            result.Add("success", new List<string>());
            result.Add("error", new List<string>());
            for (int i = 0; i < lvwPages.Items.Count; i++)
            {
                fullPath = string.Format(@"{0} {1}.{2}",
                    basePath, i.ToString("000"), outputFileType.ToString());
                Image img = (Image)lvwPages.Items[i].Tag;
                try
                {
                    img.Save(fullPath, imageFormat);
                    result["success"].Add(System.IO.Path.GetFileName(fullPath));
                }
                catch (Exception)
                {
                    result["error"].Add(System.IO.Path.GetFileName(fullPath));
                }
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("<>:?\\|/*\"".Contains(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void lvwPages_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                while (lvwPages.SelectedItems.Count > 0)
                {
                    imgListLarge.Images.RemoveAt(lvwPages.SelectedItems[0].Index);
                    lvwPages.Items.Remove(lvwPages.SelectedItems[0]);
                }
                RedefinePages();
            }
        }

        private void RedefinePages()
        {
            foreach (ListViewItem item in lvwPages.Items)
            {
                item.Text = string.Format(lang.msgPage, item.Index + 1);
            }
        }

        private void cmbOutputFileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOutputFileType.SelectedIndex >= 0)
            {
                Properties.Settings.Default.LastOutputType = cmbOutputFileType.SelectedIndex;
                Properties.Settings.Default.Save();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvwPages.Items.Clear();
            imgListLarge.Images.Clear();
        }

        private void lvwPages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtTargetDirectory.Text = fbd.SelectedPath;
            }
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            var fm = new AboutBox1(lang);

            fm.ShowDialog();

            fm.Dispose();
        }

        private void mnuImportLanguageFile_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "XML Language File|*.xml";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    var newLang = Language.Deserialize(ofd.FileName);
                    var newFile = string.Format(@"Languages\{0}", System.IO.Path.GetFileName(ofd.FileName));
                    System.IO.File.Copy(ofd.FileName, newFile, true);
                    LoadLanguages();
                    if (MessageBox.Show(string.Format(lang.msgConfirmChangeLangAfterImport, newLang.LangName)) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Properties.Settings.Default.LanguageFile = System.IO.Path.GetFileName(newFile);
                        LoadLanguage();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void mnuExportEmptyLanguageFile_Click(object sender, EventArgs e)
        {
            var exp = new Language();
            var sfd = new SaveFileDialog();

            sfd.Filter = "XML Language File|*.xml";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var fs = new FileStream(sfd.FileName, System.IO.FileMode.CreateNew, System.IO.FileAccess.ReadWrite, System.IO.FileShare.Read);
                var tw = new StreamWriter(fs, System.Text.Encoding.UTF8);
                tw.Serialize(exp);
                fs.Close();
                var xDoc = new System.Xml.XmlDocument();
                xDoc.LoadXml(System.IO.File.ReadAllText(sfd.FileName));
                string comment = "Examples:\n";
                var t = lang.GetType();
                foreach (var prop in t.GetProperties())
                {
                    var value = prop.GetValue(prop.Name);
                    comment += string.Format("{0}: {1}\n", prop.Name, value);
                }
                
                xDoc.CreateComment(comment);
            }
        }

        private void mnuSetDPI_Click(object sender, EventArgs e)
        {
            var mnu = sender as ToolStripMenuItem;
            var dpi = Convert.ToInt32( mnu.Tag);
            SetDPI(dpi);
        }

        private void SetDPI(int dpi)
        {
            Properties.Settings.Default.DPI = dpi;
            UpdateSetDPIMenuItems();
        }

        private void UpdateSetDPIMenuItems()
        {
            foreach (ToolStripMenuItem item in mnuChangeDPI.DropDownItems)
            {
                item.Checked = (Convert.ToInt32(item.Tag) == Properties.Settings.Default.DPI);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!saved && lvwPages.Items.Count > 0)
            {
                if(MessageBox.Show(lang.msgConfirmCloseWithoutSave, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
