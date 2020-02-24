using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Kanpeki_Scan
{
    [Serializable]
    [XmlRoot("Language", Namespace = "http://schema.kanpekiitsolutions.com/")]
    public class Language
    {
        public void SetDefaultValues()
        {

        }
        public string LangType { get; set; }
        public string LangName { get; set; }

        public string lblScanSources { get; set; }
        public string btnScan { get; set; }

        public string lblOutputFileType { get; set; }
        public string lblTargetDirectory { get; set; }
        public string btnBrowse { get; set; }
        public string lblDescription { get; set; }

        public string btnClear { get; set; }
        public string btnSave { get; set; }

        public string msgPage { get; set; }
        public string msgTargetDirectoryNotSet { get; set; }
        public string msgTargetDirectoryNotExist { get; set; }
        public string msgDescriptionNotDefined { get; set; }
        public string msgNoScannedPagesToSave { get; set; }
        public string msgOutputFileTypeNotDefined { get; set; }
        public string msgConfirmCloseWithoutSave { get; set; }

        public string msgSuccessSaveSingleFile { get; set; }
        public string msgSuccessSaveMultiFile { get; set; }

        public string msgAbout { get; set; }
        public string msgVersion { get; set; }

        public string msgConfirmChangeLangAfterImport { get; set; }
        
        public string mnuTools { get; set; }
        public string mnuImportLanguageFile { get; set; }
        public string mnuExportEmptyLanguageFile { get; set; }
        public string mnuChangeDPI { get; set; }

        public string mnuHelp { get; set; }
        public string mnuAbout { get; set; }
        public string mnuChangeLanguage { get; set; }

        public void SetText(Control c)
        {
            switch (c.Name)
            {
                case "lblScanSources":
                    c.Text = this.lblScanSources;
                    break;
                case "btnScan":
                    c.Text = this.btnScan;
                    break;
                case "lblOutputFileType":
                    c.Text = this.lblOutputFileType;
                    break;
                case "lblTargetDirectory":
                    c.Text = this.lblTargetDirectory;
                    break;
                case "btnBrowse":
                    c.Text = this.btnBrowse;
                    break;
                case "lblDescription":
                    c.Text = this.lblDescription;
                    break;
                case "btnClear":
                    c.Text = this.btnClear;
                    break;
                case "btnSave":
                    c.Text = this.btnSave;
                    break;
                default:
                    break;
            }
        }

        public static Language Deserialize(string fileName)
        {
            var fs = new System.IO.FileStream(fileName, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
            var tr =  new System.IO.StreamReader(fs, System.Text.Encoding.UTF8);
            var instance = tr.Deserialize<Language>();
            fs.Close();
            return instance;
        }
    }
}
