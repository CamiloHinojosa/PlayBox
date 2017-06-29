using PlayBoxSharedLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PlayBoxInteractiveReportViewer
{
    public partial class MainWindow:Form
    {
        private List<COSEReport> coseReports;
        private List<CLINReport> clinReports;
        private List<CLCOReport> clcoReports;
        private List<YECOReport> yecoReports;

        private ReportViewerDisplay rpvd;

        public MainWindow()
        {
            InitializeComponent();
            rpvd=new ReportViewerDisplay();
            rpvd.MdiParent=this;
            rpvd.AutoSize=true;
            rpvd.TopLevel=false;
            rpvd.SizeGripStyle=SizeGripStyle.Hide;
            rpvd.FormBorderStyle=FormBorderStyle.None;
            rpvd.MinimizeBox=false;
            rpvd.MaximizeBox=false;
            rpvd.Anchor=(AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right);
            _reportLayoutPanel.Controls.Add(rpvd);
            rpvd.Show();
            LoadNodes();
        }

        private void LoadNodes()
        {
            _explorer.Nodes.Clear();
            _explorer.Nodes.Add("CNxN","Console Reports");
            _explorer.Nodes["CNxN"].ImageIndex=0;
            _explorer.Nodes["CNxN"].SelectedImageIndex=0;
            _explorer.Nodes["CNxN"].Nodes.Add("COSExN","Console Session Reports");
            _explorer.Nodes["CNxN"].Nodes["COSExN"].ImageIndex=3;
            _explorer.Nodes["CNxN"].Nodes["COSExN"].SelectedImageIndex=3;

            _explorer.Nodes.Add("COxN","Consumption Reports");
            _explorer.Nodes["COxN"].ImageIndex=1;
            _explorer.Nodes["COxN"].SelectedImageIndex=1;
            _explorer.Nodes["COxN"].Nodes.Add("YECOxN","Yearly Consumption Reports");
            _explorer.Nodes["COxN"].Nodes["YECOxN"].ImageIndex=3;
            _explorer.Nodes["COxN"].Nodes["YECOxN"].SelectedImageIndex=3;

            _explorer.Nodes.Add("CLxN","Client Reports");
            _explorer.Nodes["CLxN"].ImageIndex=2;
            _explorer.Nodes["CLxN"].SelectedImageIndex=2;
            _explorer.Nodes["CLxN"].Nodes.Add("CLINxN","Clients Information Reports");
            _explorer.Nodes["CLxN"].Nodes["CLINxN"].ImageIndex=3;
            _explorer.Nodes["CLxN"].Nodes["CLINxN"].SelectedImageIndex=3;
            _explorer.Nodes["CLxN"].Nodes.Add("CLCOxN","Clients Consumption Reports");
            _explorer.Nodes["CLxN"].Nodes["CLCOxN"].ImageIndex=3;
            _explorer.Nodes["CLxN"].Nodes["CLCOxN"].SelectedImageIndex=3;
            if(GetCOSEReports())
                if(AddCOSEReports())
                    AddCOSESessions();

            if(GetCLINReports())
                AddCLINReports();
            if(GetCLCOReports())
                if(AddCLCOReports())
                    AddCLCOSessions();
            if(GetYECOReports())
                if(AddYECOReports())
                    if(AddMOCOLogs())
                        AddDACOLogs();
        }

        private bool GetYECOReports()
        {
            try
            {
                string[] reportFiles = Directory.GetFiles(ReportManager.CODirectory);
                YECOReportManager corm = new YECOReportManager();
                yecoReports=new List<YECOReport> { };
                foreach(string file in reportFiles)
                    if(corm.Load(file)!="Error")
                        yecoReports.Add(corm.Report);
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("Error Retrieving CLSE Reports: "+e.Message);
                return false;
            }
        }

        private bool GetCLCOReports()
        {
            try
            {
                string[] reportFiles = Directory.GetFiles(ReportManager.CLCODirectory);
                CLCOReportManager clcorm = new CLCOReportManager();
                clcoReports=new List<CLCOReport> { };
                foreach(string file in reportFiles)
                    if(clcorm.Load(file)!="Error")
                        clcoReports.Add(clcorm.Report);
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("Error Retrieving CLCO Reports: "+e.Message);
                return false;
            }
        }

        private bool GetCLINReports()
        {
            try
            {
                string[] reportFiles = Directory.GetFiles(ReportManager.CLINDirectory);
                CLINReportManager clinrm = new CLINReportManager();
                clinReports=new List<CLINReport> { };
                foreach(string file in reportFiles)
                {
                    clinrm.Load(file);
                    clinReports.Add(clinrm.Report);
                }
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("Error Retrieving CLIN Reports: "+e.Message);
                return false;
            }
        }

        private bool GetCOSEReports()
        {
            try
            {
                string[] reportFiles = Directory.GetFiles(ReportManager.COSEDirectory);
                COSEReportManager coserm = new COSEReportManager();
                coseReports=new List<COSEReport> { };
                foreach(string file in reportFiles)
                {
                    if(coserm.Load(file))
                        coseReports.Add(coserm.Report);
                }
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("Error retireving COSE Reports: "+e.Message);
                return false;
            }
        }

        private bool AddYECOReports()
        {
            try
            {
                foreach(YECOReport report in yecoReports)
                {
                    TreeNode reportNode = new TreeNode();
                    reportNode.Text=report.Date.Year.ToString();
                    reportNode.Name=report.Type+"$"+report.Id;
                    reportNode.Tag=report.FileName;
                    reportNode.ImageIndex=5;
                    reportNode.SelectedImageIndex=5;
                    _explorer.Nodes["COxN"].Nodes["YECOxN"].Nodes.Add(reportNode);
                }
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("Error Adding CO Reports: "+e.Message);
                return false;
            }
        }

        private bool AddMOCOLogs()
        {
            try
            {
                foreach(YECOReport report in yecoReports)
                {
                    foreach(KeyValuePair<string,MOCOLog> log in report.MOCOLogs)
                    {
                        TreeNode logNode = new TreeNode();
                        logNode.Text=log.Value.Date.ToString("MMMM");
                        logNode.Name=log.Value.Type+"$"+report.Id+"$"+log.Key;
                        logNode.ImageIndex=7;
                        logNode.SelectedImageIndex=7;
                        _explorer.Nodes["COxN"].Nodes["YECOxN"].Nodes[report.Type+"$"+report.Id].ImageIndex=6;
                        _explorer.Nodes["COxN"].Nodes["YECOxN"].Nodes[report.Type+"$"+report.Id].SelectedImageIndex=6;
                        _explorer.Nodes["COxN"].Nodes["YECOxN"].Nodes[report.Type+"$"+report.Id].Nodes.Add(logNode);
                    }
                }
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("Error retireving MOCO Logs: "+e.Message);
                return false;
            }
        }

        private void AddDACOLogs()
        {
            try
            {
                foreach(YECOReport report in yecoReports)
                {
                    foreach(KeyValuePair<string,MOCOLog> mocolog in report.MOCOLogs)
                    {
                        foreach(KeyValuePair<string,DACOLog> log in mocolog.Value.DACOLogs)
                        {
                            TreeNode logNode = new TreeNode();
                            logNode.Text=log.Value.Date.ToLongDateString();
                            logNode.Name=log.Value.Type+"$"+report.Id+"$"+mocolog.Key+"$"+log.Key;
                            logNode.ImageIndex=7;
                            logNode.SelectedImageIndex=7;
                            _explorer.Nodes["COxN"].Nodes["YECOxN"].Nodes[report.Type+"$"+report.Id].Nodes[mocolog.Value.Type+"$"+report.Id+"$"+mocolog.Key].ImageIndex=6;
                            _explorer.Nodes["COxN"].Nodes["YECOxN"].Nodes[report.Type+"$"+report.Id].Nodes[mocolog.Value.Type+"$"+report.Id+"$"+mocolog.Key].SelectedImageIndex=6;
                            _explorer.Nodes["COxN"].Nodes["YECOxN"].Nodes[report.Type+"$"+report.Id].Nodes[mocolog.Value.Type+"$"+report.Id+"$"+mocolog.Key].Nodes.Add(logNode);
                        }
                    }
                }
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("Error retireving DACO Logs: "+e.Message);
            }
        }
        
        private void AddCLCOSessions()
        {
            try
            {
                foreach(CLCOReport report in clcoReports)
                {
                    foreach(KeyValuePair<uint,CLCOLog> log in report.Clients)
                    {
                        TreeNode coseSessionNode = new TreeNode();
                        coseSessionNode.Text=log.Value.ClientName+" ("+log.Value.Id.ToString()+") - "+log.Value.Name;
                        coseSessionNode.Name=log.Value.Type+"$"+report.Id+"$"+log.Key;
                        coseSessionNode.ImageIndex=7;
                        coseSessionNode.SelectedImageIndex=7;
                        _explorer.Nodes["CLxN"].Nodes["CLCOxN"].Nodes[report.Type+"$"+report.Id].ImageIndex=6;
                        _explorer.Nodes["CLxN"].Nodes["CLCOxN"].Nodes[report.Type+"$"+report.Id].SelectedImageIndex=6;
                        _explorer.Nodes["CLxN"].Nodes["CLCOxN"].Nodes[report.Type+"$"+report.Id].Nodes.Add(coseSessionNode);
                    }
                }
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("Error retireving COSE Sessions: "+e.Message);
            }
        }
        
        private bool AddCLCOReports()
        {
            try
            {
                foreach(CLCOReport report in clcoReports)
                {
                    TreeNode clcoReportNode = new TreeNode();
                    clcoReportNode.Text=report.Name+" ("+report.Id.ToString()+")";
                    clcoReportNode.Name=report.Type+"$"+report.Id;
                    clcoReportNode.Tag=report.FileName;
                    clcoReportNode.ImageIndex=5;
                    clcoReportNode.SelectedImageIndex=5;
                    _explorer.Nodes["CLxN"].Nodes["CLCOxN"].Nodes.Add(clcoReportNode);
                }
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("Error Adding CLCO Reports: "+e.Message);
                return false;
            }
        }

        private void AddCLINReports()
        {
            try
            {
                foreach(CLINReport report in clinReports)
                {
                    TreeNode clinReportNode = new TreeNode();
                    clinReportNode.Text=report.Name+" ("+report.Id.ToString()+")";
                    clinReportNode.Name=report.Type+"$"+report.Id;
                    clinReportNode.Tag=report.FileName;
                    clinReportNode.ImageIndex=4;
                    clinReportNode.SelectedImageIndex=4;
                    _explorer.Nodes["CLxN"].Nodes["CLINxN"].Nodes.Add(clinReportNode);
                }
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("Error Adding CLIN Reports: "+e.Message);
            }
        }

        private bool AddCOSEReports()
        {
            try
            {
                foreach(COSEReport report in coseReports)
                {
                    TreeNode coseReportNode = new TreeNode();
                    coseReportNode.Text=report.ConsoleName+" ("+report.ConsoleId.ToString()+") - "+report.Name+" "+report.Id.ToString();
                    coseReportNode.Name=report.Type+"$"+report.Id;
                    coseReportNode.Tag=report.FileName;
                    coseReportNode.ImageIndex=6;
                    coseReportNode.SelectedImageIndex=6;
                    _explorer.Nodes["CNxN"].Nodes["COSExN"].Nodes.Add(coseReportNode);
                }
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("Error Adding COSE Reports: "+e.Message);
                return false;
            }
        }

        private void AddCOSESessions()
        {
            try
            {
                foreach(COSEReport report in coseReports)
                {
                    foreach(COSELog session in report.Sessions)
                    {
                        TreeNode coseSessionNode = new TreeNode();
                        coseSessionNode.Text=session.Name+" ("+session.Id.ToString()+")";
                        coseSessionNode.Name=session.Type+"$"+report.Id+"$"+session.Id;
                        coseSessionNode.Tag=report.FileName+"$"+session.Id;
                        coseSessionNode.ImageIndex=7;
                        coseSessionNode.SelectedImageIndex=7;
                        _explorer.Nodes["CNxN"].Nodes["COSExN"].Nodes[report.Type+"$"+report.Id].ImageIndex=6;
                        _explorer.Nodes["CNxN"].Nodes["COSExN"].Nodes[report.Type+"$"+report.Id].SelectedImageIndex=6;
                        _explorer.Nodes["CNxN"].Nodes["COSExN"].Nodes[report.Type+"$"+report.Id].Nodes.Add(coseSessionNode);
                    }
                }
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("Error retireving COSE Sessions: "+e.Message);
            }
        }

        private void LoadAndShowNode(string[] elements)
        {
            try
            {
                switch(elements[0])
                {
                    case "YECOxR":
                        rpvd.LoadYECOReport(yecoReports[int.Parse(elements[1])]);
                        break;

                    case "MOCOxL":
                        rpvd.LoadMOCOLog(yecoReports[int.Parse(elements[1])].MOCOLogs[elements[2]]);
                        break;

                    case "DACOxL":
                        rpvd.LoadDACOLog(yecoReports[int.Parse(elements[1])].MOCOLogs[elements[2]].DACOLogs[elements[3]]);
                        break;

                    case "CLCOxR":
                        rpvd.LoadCLCOReport(clcoReports[int.Parse(elements[1])]);
                        break;

                    case "CLCOxL":
                        rpvd.LoadCLCOLog(clcoReports[int.Parse(elements[1])].Clients[uint.Parse(elements[2])]);
                        break;

                    case "CLINxR":
                        rpvd.LoadCLINReport(clinReports[int.Parse(elements[1])]);
                        break;

                    case "COSExR":
                        rpvd.LoadCOSEReportBySession(coseReports[int.Parse(elements[1])]);
                        break;

                    case "COSExS":
                        rpvd.LoadCOSESession(coseReports[int.Parse(elements[1])].Sessions[int.Parse(elements[2])]);
                        break;
                }
            } catch(Exception e)
            {
                MessageLogManager.LogMessage("LASN error: "+e.Message+"\n"+e.InnerException+"\n"+e.Source+"\n"+e.TargetSite);
            }
        }

        private void _explorer_NodeMouseClick(object sender,TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.Name!=null)
                LoadAndShowNode(e.Node.Name.ToString().Split('$'));
        }

        private void _resetBTN_Click(object sender,EventArgs e)
        {
            LoadNodes();
        }

        private void _explorer_KeyDown(object sender,KeyEventArgs e)
        {
            if(_explorer.SelectedNode!=null&&e.KeyValue==13)
            {
                LoadAndShowNode(_explorer.SelectedNode.Name.ToString().Split('$'));
                _explorer.Focus();
                e.Handled=true;
                e.SuppressKeyPress=true;
            }
        }
        private void _exportToExcelBTN_Click(object sender,EventArgs e)
        {

        }
    }
}