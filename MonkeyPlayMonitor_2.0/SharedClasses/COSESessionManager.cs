using System;

namespace PlayBoxReporting
{
    internal class COSESessionManager:COSEReportManager
    {
        public uint AddSession()
        {
            uint id;
            try
            {
                id=(uint)COSExR.Sessions.Count;
                COSExR.Sessions.Add(new COSELog());
                COSExR.Sessions[(int)id].Id=id;
                COSExR.Sessions[(int)id].Name="Console Session";
                COSExR.Sessions[(int)id].Date=DateTime.Now;
                COSExR.Sessions[(int)id].Type="COSExS";
            } catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine("AddSession ERROR: "+e.Message);
                return 0;
            }
            return id;
        }

        public bool StartSession(uint sessionId,uint clientId,DateTime startTime)
        {
            try
            {
                COSExR.Sessions[(int)sessionId].ClientId=clientId;
                COSExR.Sessions[(int)sessionId].StartTime=startTime;
                return true;
            } catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine("StartSession ERROR: "+e.Message);
                return false;
            }
        }

        public bool EndSession(uint sessionId,DateTime endTime,TimeSpan totalTime,double totalConsumption)
        {
            try
            {
                COSExR.Sessions[(int)sessionId].EndTime=endTime;
                COSExR.Sessions[(int)sessionId].TotalTime=totalTime;
                COSExR.Sessions[(int)sessionId].TotalConsumption=totalConsumption;
                return true;
            } catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine("EndSession ERROR: "+e.Message);
                return false;
            }
        }

        public uint AddLog(uint sessionId)
        {
            uint logId;
            try
            {
                logId=(uint)COSExR.Sessions[(int)sessionId].Logs.Count;
                COSExR.Sessions[(int)sessionId].Logs.Add(new COACLog());
                COSExR.Sessions[(int)sessionId].Logs[(int)logId].Id=logId;
                COSExR.Sessions[(int)sessionId].Logs[(int)logId].Name="Console Activity Log";
                COSExR.Sessions[(int)sessionId].Logs[(int)logId].Date=DateTime.Now;
                COSExR.Sessions[(int)sessionId].Logs[(int)logId].Type="COACxL";
            } catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine("AddLog ERROR: "+e.Message);
                return 0;
            }
            return logId;
        }

        public bool StartLog(uint sessionId,uint logId,string eventName,uint extraConstrols,DateTime startTime)
        {
            try
            {
                COSExR.Sessions[(int)sessionId].Logs[(int)logId].Name="";
                COSExR.Sessions[(int)sessionId].Logs[(int)logId].Date=DateTime.Now;
                COSExR.Sessions[(int)sessionId].Logs[(int)logId].Type="";
                COSExR.Sessions[(int)sessionId].Logs[(int)logId].EventName=eventName;
                COSExR.Sessions[(int)sessionId].Logs[(int)logId].ExtraControls=extraConstrols;
                COSExR.Sessions[(int)sessionId].Logs[(int)logId].StartTime=startTime;
                return true;
            } catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine("StartLog ERROR: "+e.Message);
                return false;
            }
        }

        public bool EndLog(uint sessionId,uint logId,DateTime endTime,TimeSpan totalTime,double totalConsumption)
        {
            try
            {
                COSExR.Sessions[(int)sessionId].Logs[(int)logId].EndTime=endTime;
                COSExR.Sessions[(int)sessionId].Logs[(int)logId].TotalTime=totalTime;
                COSExR.Sessions[(int)sessionId].Logs[(int)logId].TotalConsumption=totalConsumption;
            } catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine("EndLog ERROR: "+e.Message);
                return false;
            }
            return true;
        }

        public void DeleteLastSession()
        {
            COSExR.Sessions.RemoveAt(COSExR.Sessions.Count-1);
        }

        public void CopySession(uint sessionId,COSELog inputSession)
        {
            COACLog[] temp = new COACLog[inputSession.Logs.Count];
            COSExR.Sessions[(int)sessionId].ClientId=inputSession.ClientId;
            COSExR.Sessions[(int)sessionId].Date=inputSession.Date;
            COSExR.Sessions[(int)sessionId].EndTime=inputSession.EndTime;
            COSExR.Sessions[(int)sessionId].Name=inputSession.Name;
            COSExR.Sessions[(int)sessionId].StartTime=inputSession.StartTime;
            COSExR.Sessions[(int)sessionId].TotalConsumption=inputSession.TotalConsumption;
            COSExR.Sessions[(int)sessionId].TotalTime=inputSession.TotalTime;
            COSExR.Sessions[(int)sessionId].Type=inputSession.Type;
            inputSession.Logs.CopyTo(temp);
            COSExR.Sessions[(int)sessionId].Logs.AddRange(temp);
        }
    }
}