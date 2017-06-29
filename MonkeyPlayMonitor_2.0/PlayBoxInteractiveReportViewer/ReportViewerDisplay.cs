using PlayBoxSharedLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PlayBoxInteractiveReportViewer
{
    public partial class ReportViewerDisplay:Form
    {
        private OpenFileDialog ofd;
        private COSEReportManager coserm;
        private CLINReportManager clinrm;
        private CLCOReportManager clcorm;
        private YECOReportManager yecorm;

        private DataGridViewTextBoxColumn _field1 = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn _field2 = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn _field3 = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn _field4 = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn _field5 = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn _field6 = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn _field7 = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn _field8 = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn _field9 = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn _field10 = new DataGridViewTextBoxColumn();

        private List<Label> labels;
        private List<FlowLayoutPanel> panels;

        public ReportViewerDisplay()
        {
            InitializeComponent();
            LoadPanels();
            LoadLabels();
        }

        private void LoadLabels()
        {
            labels=new List<Label> { };
            labels.Add(_label1);
            labels.Add(_label2);
            labels.Add(_label3);
            labels.Add(_label4);
            labels.Add(_label5);
            labels.Add(_label6);
            labels.Add(_label7);
            labels.Add(_label8);
            labels.Add(_label9);
            labels.Add(_label10);
            labels.Add(_label11);
            labels.Add(_label12);
            labels.Add(_label13);
        }

        private void LoadPanels()
        {
            panels=new List<FlowLayoutPanel> { };
            panels.Add(_lblpptContainer1);
            panels.Add(_lblpptContainer2);
            panels.Add(_lblpptContainer3);
            panels.Add(_lblpptContainer4);
            panels.Add(_lblpptContainer5);
            panels.Add(_lblpptContainer6);
            panels.Add(_lblpptContainer7);
            panels.Add(_lblpptContainer8);
            panels.Add(_lblpptContainer9);
            panels.Add(_lblpptContainer10);
            panels.Add(_lblpptContainer11);
            panels.Add(_lblpptContainer12);
            panels.Add(_lblpptContainer13);
        }

        [STAThread]
        public void ShowOpenFileDialog()
        {
            using(ofd=new OpenFileDialog())
            {
                ofd.InitialDirectory=ReportManager.reportsDirectory;
                if(ofd.ShowDialog()==DialogResult.OK)
                    if(ShowReportsByName(ofd.FileName))
                    {
                        Visible=false;
                        ShowDialog();
                    }
            }
        }

        private bool ShowReportsByName(string reportName)
        {
            try
            {
                if(reportName.Contains("CLINxR"))
                {
                    if(OpenCLINReport(reportName))
                        if(LoadCLINReport(clinrm.Report))
                            return true;
                }
                else if(reportName.Contains("CLCOxR"))
                {
                    if(OpenCLCOReport(reportName))
                        if(LoadCLCOReport(clcorm.Report))
                            return true;
                }
                else if(reportName.Contains("COSExR"))
                {
                    if(OpenCOSEReport(reportName))
                        if(LoadCOSEReportByLogs(coserm.Report))
                            return true;
                }
                else if(reportName.Contains("YECOxR"))
                {
                    if(OpenYECOReport(reportName))
                        if(LoadYECOReport(yecorm.Report))
                            return true;
                }
            } catch(Exception e)
            {
                MessageBox.Show(e.Message);
                MessageLogManager.LogMessage(e.Message+e.Data+"\n"+e.InnerException+"\n"+e.Source);
            }
            return false;
        }

        private bool OpenCOSEReport(string reportName)
        {
            coserm=new COSEReportManager();
            return coserm.Load(reportName);
        }

        private bool OpenYECOReport(string reportName)
        {
            yecorm=new YECOReportManager();
            return yecorm.LoadOnly(reportName);
        }

        private bool OpenCLINReport(string reportName)
        {
            clinrm=new CLINReportManager();
            return clinrm.Load(reportName);
        }

        private bool OpenCLCOReport(string reportName)
        {
            clcorm=new CLCOReportManager();
            if(clcorm.Load(reportName)!="Error")
                return true;
            else
                return false;
        }

        public bool LoadYECOReport(YECOReport report)
        {
            try
            {
                Visible=false;
                InitializeComunColumns();
                InitializeYECOReportDVGComponents();
                AddYECOReportColumns();
                _propertyfield1.Text=report.Name;
                _propertyfield2.Text=report.Id.ToString();
                _propertyfield3.Text=report.Type;
                _propertyfield4.Text=report.Date.ToLongDateString();
                _propertyfield5.Text=report.Date.ToLongTimeString();
                _propertyfield6.Text=report.MOCOLogs.Count.ToString();
                _propertyfield7.Text=report.StartTime.ToLongTimeString();
                _propertyfield8.Text=report.EndTime.ToLongTimeString();
                _propertyfield9.Text=report.TotalTime.ToString();
                _propertyfield11.Text=report.TotalConsumption.ToString();
                _propertyfield12.Text="";
                _propertyfield13.Text=report.FileName;
                _propertyfield10.Text=report.PathName;
                InitializeLBL(new int[] { 0,1,2,3,4,5,6,7,8,9,10,12 },
                    new string[] { "Name:","ID:","Type:",
                    "Date Created:","Time Created:","Log Count:",
                    "Start Time:","End Time:","Total Time:",
                    "File Location:","Total Consumption:","File Name:"});
                PadLabels(18);
                foreach(KeyValuePair<string,MOCOLog> log in report.MOCOLogs)
                    _reportDataGrid.Rows.Add(log.Value.Id,log.Key,log.Value.Sessions.Count,log.Value.StartTime.ToString(),log.Value.EndTime.ToString(),log.Value.TotalTime.ToString(),log.Value.TotalConsumption.ToString());
                Visible=true;
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage(e.Message+e.Data+"\n"+e.InnerException+"\n"+e.Source);
                return false;
            }
        }

        public bool LoadMOCOLog(MOCOLog log)
        {
            try
            {
                Visible=false;
                InitializeComunColumns();
                InitializeMOCOReportDVGComponents();
                AddYECOReportColumns();
                _propertyfield1.Text=log.Name;
                _propertyfield2.Text=log.Id.ToString();
                _propertyfield3.Text=log.Type;
                _propertyfield4.Text=log.Date.ToLongDateString();
                _propertyfield5.Text=log.Date.ToLongTimeString();
                _propertyfield6.Text=log.DACOLogs.Count.ToString();
                _propertyfield7.Text=log.StartTime.ToLongTimeString();
                _propertyfield8.Text=log.EndTime.ToLongTimeString();
                _propertyfield9.Text=log.TotalTime.ToString();
                _propertyfield10.Text=log.TotalConsumption.ToString();
                _propertyfield11.Text="";
                _propertyfield12.Text="";
                _propertyfield13.Text="";
                InitializeLBL(new int[] { 0,1,2,3,4,5,6,7,8,9 },
                    new string[] { "Name:","ID:","Type:",
                    "Date Created:","Time Created:","Log Count:",
                    "Start Time:","End Time:","Total Time:",
                    "Total Consumption:"});
                PadLabels(19);
                foreach(KeyValuePair<string,DACOLog> session in log.DACOLogs)
                    _reportDataGrid.Rows.Add(session.Value.Id,session.Key,session.Value.Sessions.Count,session.Value.StartTime.ToString(),session.Value.EndTime.ToString(),session.Value.TotalTime.ToString(),session.Value.TotalConsumption.ToString());
                Visible=true;
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage(e.Message+e.Data+"\n"+e.InnerException+"\n"+e.Source);
                return false;
            }
        }

        public bool LoadDACOLog(DACOLog log)
        {
            try
            {
                Visible=false;
                InitializeComunColumns();
                InitializeCOSESessionReportDGVComponents();
                AddCOSESessionReportColumns();
                _propertyfield1.Text=log.Name;
                _propertyfield2.Text=log.Id.ToString();
                _propertyfield3.Text=log.Type;
                _propertyfield4.Text=log.Date.ToLongDateString();
                _propertyfield5.Text=log.Sessions.Count.ToString();
                _propertyfield6.Text=log.StartTime.ToString();
                _propertyfield7.Text=log.EndTime.ToString();
                _propertyfield8.Text=log.TotalTime.ToString();
                _propertyfield9.Text=log.TotalConsumption.ToString();
                _propertyfield10.Text="";
                _propertyfield11.Text="";
                _propertyfield12.Text="";
                _propertyfield13.Text="";
                InitializeLBL(new int[] { 0,1,2,3,4,5,6,7,8 },
                    new string[] { "Name:","ID:","Type:",
                    "Date Created:","Session Count:",
                    "Start Time:","End Time:","Total Time:",
                    "Total Consumption:"});
                PadLabels(19);
                foreach(COSELog session in log.Sessions)
                    _reportDataGrid.Rows.Add(session.Id.ToString(),session.ClientId.ToString(),session.StartTime.ToString(),session.EndTime.ToString(),session.TotalTime.ToString(),session.TotalConsumption.ToString());
                Visible=true;
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage(e.Message+e.Data+"\n"+e.InnerException+"\n"+e.Source);
                return false;
            }
        }

        public bool LoadCLCOLog(CLCOLog log)
        {
            try
            {
                Visible=false;
                InitializeComunColumns();
                InitializeCOSESessionReportDGVComponents();
                AddCOSESessionReportColumns();
                _propertyfield1.Text=log.Name;
                _propertyfield2.Text=log.Id.ToString();
                _propertyfield3.Text=log.Type;
                _propertyfield4.Text=log.Date.ToLongDateString();
                _propertyfield5.Text=log.Date.ToLongTimeString();
                _propertyfield6.Text=log.ClientName;
                _propertyfield7.Text=log.SessionCount.ToString();
                _propertyfield8.Text=log.TotalTime.ToString();
                _propertyfield9.Text=log.TotalConsumption.ToString();
                _propertyfield10.Text="";
                _propertyfield11.Text="";
                _propertyfield12.Text="";
                _propertyfield13.Text="";
                InitializeLBL(new int[] { 0,1,2,3,4,5,6,7,8 },
                    new string[] { "Name:","ID (Client ID):","Type:",
                    "Date Created:","Time Created:","Client Name:","Sessions:","Total Time:","Total Consumption:"});
                PadLabels(15);
                foreach(COSELog session in log.Sessions)
                    _reportDataGrid.Rows.Add(session.Id.ToString(),session.ClientId.ToString(),session.StartTime.ToString(),session.EndTime.ToString(),session.TotalTime.ToString(),session.TotalConsumption.ToString());
                Visible=true;
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage(e.Message+e.Data+"\n"+e.InnerException+"\n"+e.Source);
                return false;
            }
        }

        public bool LoadCLCOReport(CLCOReport report)
        {
            try
            {
                Visible=false;
                InitializeCLCOReportDVGComponents();
                AddCLCOReportColumns();
                _propertyfield1.Text=report.Name;
                _propertyfield2.Text=report.Id.ToString();
                _propertyfield3.Text=report.Type;
                _propertyfield4.Text=report.Date.ToLongDateString();
                _propertyfield5.Text=report.Date.ToLongTimeString();
                _propertyfield6.Text="";
                _propertyfield7.Text="";
                _propertyfield8.Text="";
                _propertyfield9.Text=report.FileName;
                _propertyfield10.Text=report.PathName;
                _propertyfield11.Text="";
                _propertyfield12.Text="";
                _propertyfield13.Text="";
                InitializeLBL(new int[] { 0,1,2,3,4,8,9 },
                    new string[] { "Name:","ID:","Type:",
                    "Date Created:","Time Created:","File Name:",
                    "File Location:"});
                PadLabels(15);
                foreach(KeyValuePair<uint,CLCOLog> log in report.Clients)
                    _reportDataGrid.Rows.Add(log.Value.Id.ToString(),log.Value.ClientName,log.Value.SessionCount,log.Value.TotalTime,log.Value.TotalConsumption);
                Visible=true;
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage(e.Message+e.Data+"\n"+e.InnerException+"\n"+e.Source);
                return false;
            }
        }

        public bool LoadCLINReport(CLINReport report)
        {
            try
            {
                Visible=false;
                InitializeCLINReportDVGComponents();
                AddCLINReportColumns();
                _propertyfield1.Text=report.Name;
                _propertyfield2.Text=report.Id.ToString();
                _propertyfield3.Text=report.Type;
                _propertyfield4.Text=report.Date.ToLongDateString();
                _propertyfield5.Text=report.Date.ToLongTimeString();
                _propertyfield6.Text="";
                _propertyfield7.Text="";
                _propertyfield8.Text="";
                _propertyfield9.Text=report.FileName;
                _propertyfield10.Text=report.PathName;
                _propertyfield11.Text="";
                _propertyfield12.Text="";
                _propertyfield13.Text="";
                InitializeLBL(new int[] { 0,1,2,3,4,8,9 },
                    new string[] { "Name:","ID:","Type:",
                    "Date Created:","Time Created:","File Name:",
                    "File Location:"});
                PadLabels(15);
                foreach(KeyValuePair<string,CLINLog> log in report.Clients)
                    _reportDataGrid.Rows.Add(log.Value.Id.ToString(),log.Value.ClientName,log.Value.DocId,log.Value.PhoneNumber,log.Value.DateOfBirth);
                Visible=true;
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage(e.Message+e.Data+"\n"+e.InnerException+"\n"+e.Source);
                return false;
            }
        }

        public bool LoadCOSEReportBySession(COSEReport report)
        {
            try
            {
                Visible=false;
                InitializeComunColumns();
                InitializeCOSESessionReportDGVComponents();
                AddCOSESessionReportColumns();
                _propertyfield1.Text=report.Name;
                _propertyfield2.Text=report.Id.ToString();
                _propertyfield3.Text=report.Type;
                _propertyfield4.Text=report.Date.ToLongDateString();
                _propertyfield5.Text=report.Date.ToLongTimeString();
                _propertyfield6.Text="";
                _propertyfield7.Text="";
                _propertyfield8.Text="";
                _propertyfield9.Text=report.FileName;
                _propertyfield10.Text=report.PathName;
                _propertyfield11.Text="";
                _propertyfield12.Text="";
                _propertyfield13.Text="";
                InitializeLBL(new int[] { 0,1,2,3,4,8,9 },
                    new string[] { "Name:","ID:","Type:",
                    "Date Created:","Time Created:","File Name:",
                    "File Location:"});
                PadLabels(15);
                foreach(COSELog session in report.Sessions)
                    _reportDataGrid.Rows.Add(session.Id.ToString(),session.ClientId.ToString(),session.StartTime.ToString(),session.EndTime.ToString(),session.TotalTime.ToString(),session.TotalConsumption.ToString());
                Visible=true;
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage(e.Message+e.Data+"\n"+e.InnerException+"\n"+e.Source);
                return false;
            }
        }

        public bool LoadCOSEReportByLogs(COSEReport report)
        {
            try
            {
                Visible=false;
                InitializeComunColumns();
                InitializeCOSELogReportDGVComponents();
                AddCOSELogReportColumns();
                int count = 0;
                _propertyfield1.Text=report.Name;
                _propertyfield2.Text=report.Id.ToString();
                _propertyfield3.Text=report.Type;
                _propertyfield4.Text=report.Date.ToLongDateString();
                _propertyfield5.Text=report.Date.ToLongTimeString();
                _propertyfield6.Text="";
                _propertyfield7.Text="";
                _propertyfield8.Text="";
                _propertyfield9.Text=report.FileName;
                _propertyfield10.Text=report.PathName;
                _propertyfield11.Text="";
                _propertyfield12.Text="";
                _propertyfield13.Text="";
                InitializeLBL(new int[] { 0,1,2,3,4,8,9 },
                    new string[] { "Name:","ID:","Type:",
                    "Date Created:","Time Created:","File Name:",
                    "File Location:"});
                PadLabels(15);
                foreach(COSELog session in report.Sessions)
                {
                    count=0;
                    foreach(COACLog log in session.Logs)
                    {
                        _reportDataGrid.Rows.Add(log.Id.ToString(),log.EventName,log.ExtraControls.ToString(),log.StartTime.ToLongTimeString(),log.EndTime.ToLongTimeString(),log.TotalTime.ToString(),log.TotalConsumption.ToString());
                        count++;
                    }
                    _reportDataGrid.Rows[_reportDataGrid.Rows.Count-count].DefaultCellStyle.BackColor=System.Drawing.Color.FromArgb(150,200,160);
                }
                Visible=true;
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage(e.Message+e.Data+"\n"+e.InnerException+"\n"+e.Source);
                return false;
            }
        }

        public bool LoadCOSESession(COSELog session)
        {
            try
            {
                Visible=false;
                InitializeComunColumns();
                InitializeCOSELogReportDGVComponents();
                AddCOSELogReportColumns();
                _propertyfield1.Text=session.Name;
                _propertyfield2.Text=session.Id.ToString();
                _propertyfield3.Text=session.Type;
                _propertyfield4.Text=session.Date.ToLongDateString();
                _propertyfield5.Text=session.ClientId.ToString();
                _propertyfield6.Text=session.Logs.Count.ToString();
                _propertyfield7.Text=session.StartTime.ToLongTimeString();
                _propertyfield8.Text=session.EndTime.ToLongTimeString();
                _propertyfield9.Text=session.TotalTime.ToString();
                _propertyfield10.Text=session.TotalConsumption.ToString();
                _propertyfield11.Text="";
                _propertyfield12.Text="";
                _propertyfield13.Text="";
                InitializeLBL(new int[] { 0,1,2,3,4,5,6,7,8,9 },
                    new string[] { "Name:","ID:","Type:",
                    "Date Created:","Client ID:","Log Count:",
                    "Start Time:","End Time:","Total Time:",
                    "Total Consumption:"});
                PadLabels(19);
                foreach(COACLog log in session.Logs)
                    _reportDataGrid.Rows.Add(log.Id.ToString(),log.EventName,log.ExtraControls.ToString(),log.StartTime.ToLongTimeString(),log.EndTime.ToLongTimeString(),log.TotalTime.ToString(),log.TotalConsumption.ToString());

                Visible=true;
                return true;
            } catch(Exception e)
            {
                MessageLogManager.LogMessage(e.Message+e.Data+"\n"+e.InnerException+"\n"+e.Source);
                return false;
            }
        }

        private void _refreshTimer_Tick(object sender,EventArgs e)
        {
        }

        private void ResizePropertyBoxes()
        {
            foreach(FlowLayoutPanel panel in _labelContainer.Controls)
            {
                foreach(Control txtBx in panel.Controls)
                {
                    if(txtBx is TextBox&&txtBx.Text!="")
                    {
                        System.Drawing.Size size = TextRenderer.MeasureText(txtBx.Text,txtBx.Font);
                        if(size.Width>300)
                            txtBx.Width=size.Width;
                        else
                            txtBx.Width=300;
                    }
                }
            }
        }

        private void PadLabels(int pad)
        {
            foreach(FlowLayoutPanel panel in _labelContainer.Controls)
            {
                foreach(Control lbl in panel.Controls)
                {
                    if(lbl is Label&&lbl.Text!="")
                    {
                        if(lbl.Text.Length<=pad)
                            lbl.Text=lbl.Text.PadRight(pad,' ');
                    }
                }
            }
        }

        private void InitializeLBL(int[] label,string[] labelText)
        {
            foreach(FlowLayoutPanel flp in panels)
                flp.Visible=false;
            for(int i = 0;i<label.Length;i++)
            {
                labels[label[i]].Text=labelText[i];
                panels[label[i]].Visible=true;
            }
            ResizePropertyBoxes();
        }
        
        private void InitializeYECOReportDVGComponents()
        {
            _reportDataGrid.Rows.Clear();
            _reportDataGrid.Columns.Clear();
            _field1=new DataGridViewTextBoxColumn();
            _field1.HeaderText="Log ID";
            _field6=new DataGridViewTextBoxColumn();
            _field6.HeaderText="Month";
            _field7=new DataGridViewTextBoxColumn();
            _field7.HeaderText="No. Of Sessions";
        }

        private void InitializeMOCOReportDVGComponents()
        {
            _reportDataGrid.Rows.Clear();
            _reportDataGrid.Columns.Clear();
            _field1=new DataGridViewTextBoxColumn();
            _field1.HeaderText="Log ID";
            _field6=new DataGridViewTextBoxColumn();
            _field6.HeaderText="Date";
            _field7=new DataGridViewTextBoxColumn();
            _field7.HeaderText="No. Of Sessions";
        }

        private void InitializeCLCOReportDVGComponents()
        {
            _reportDataGrid.Rows.Clear();
            _reportDataGrid.Columns.Clear();
            _field1=new DataGridViewTextBoxColumn();
            _field1.HeaderText="Log ID";
            _field2=new DataGridViewTextBoxColumn();
            _field2.HeaderText="Client Name";
            _field3=new DataGridViewTextBoxColumn();
            _field3.HeaderText="Sessions";
            _field4=new DataGridViewTextBoxColumn();
            _field4.HeaderText="Total Time";
            _field5=new DataGridViewTextBoxColumn();
            _field5.HeaderText="Total Consumption";
        }

        private void InitializeCLINReportDVGComponents()
        {
            _reportDataGrid.Rows.Clear();
            _reportDataGrid.Columns.Clear();
            _field1=new DataGridViewTextBoxColumn();
            _field1.HeaderText="Client ID";
            _field2=new DataGridViewTextBoxColumn();
            _field2.HeaderText="Name";
            _field3=new DataGridViewTextBoxColumn();
            _field3.HeaderText="Document ID";
            _field4=new DataGridViewTextBoxColumn();
            _field4.HeaderText="Phone Number";
            _field5=new DataGridViewTextBoxColumn();
            _field5.HeaderText="Date Of Birth";
        }

        private void InitializeCOSELogReportDGVComponents()
        {
            _field1=new DataGridViewTextBoxColumn();
            _field1.HeaderText="Activity ID";
            _field7=new DataGridViewTextBoxColumn();
            _field7.HeaderText="Event Name";
            _field8=new DataGridViewTextBoxColumn();
            _field8.HeaderText="Extra Controls";
        }

        private void InitializeCOSESessionReportDGVComponents()
        {
            _field1=new DataGridViewTextBoxColumn();
            _field1.HeaderText="Session ID";
            _field7=new DataGridViewTextBoxColumn();
            _field7.HeaderText="Client ID";
        }

        private void InitializeComunColumns()
        {
            _reportDataGrid.Rows.Clear();
            _reportDataGrid.Columns.Clear();
            _field2=new DataGridViewTextBoxColumn();
            _field2.HeaderText="Start Time";
            _field3=new DataGridViewTextBoxColumn();
            _field3.HeaderText="End Time";
            _field4=new DataGridViewTextBoxColumn();
            _field4.HeaderText="Total Time";
            _field5=new DataGridViewTextBoxColumn();
            _field5.HeaderText="Total Consumption";
        }

        private void AddYECOReportColumns()
        {
            _reportDataGrid.Columns.AddRange(new DataGridViewColumn[] { _field1,_field6,_field7,_field2,_field3,_field4,_field5 });
            _reportDataGrid.Refresh();
        }

        private void AddCLCOReportColumns()
        {
            _reportDataGrid.Columns.AddRange(new DataGridViewColumn[] { _field1,_field2,_field3,_field4,_field5 });
            _reportDataGrid.Refresh();
        }

        private void AddCLINReportColumns()
        {
            _reportDataGrid.Columns.AddRange(new DataGridViewColumn[] { _field1,_field2,_field3,_field4,_field5 });
            _reportDataGrid.Refresh();
        }

        private void AddCOSELogReportColumns()
        {
            _reportDataGrid.Columns.AddRange(new DataGridViewColumn[] { _field1,_field7,_field8,_field2,_field3,_field4,_field5 });
            _reportDataGrid.Refresh();
        }

        private void AddCOSESessionReportColumns()
        {
            _reportDataGrid.Columns.AddRange(new DataGridViewColumn[] { _field1,_field7,_field2,_field3,_field4,_field5 });
            _reportDataGrid.Refresh();
        }
    }
}