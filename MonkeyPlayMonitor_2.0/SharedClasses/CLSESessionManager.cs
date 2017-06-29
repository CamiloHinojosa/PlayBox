using System;

namespace PlayBoxReporting
{
    internal class CLSESessionManager:CLSEReportManager
    {

        public uint AddClient()
        {
            uint id;
            try
            {
                id=(uint)CLSExR.Clients.Count;
                CLSExR.Clients.Add(new CLSELog());
                CLSExR.Clients[(int)id].Id=id;
                CLSExR.Clients[(int)id].Name="Client Session";
                CLSExR.Clients[(int)id].Date=DateTime.Now;
                CLSExR.Clients[(int)id].Type="CLSExS";
            } catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine("AddClient ERROR: "+e.Message);
                return 0;
            }
            return id;
        }

        public bool StartLog(uint clientId,string consoleName, uint consoleId, uint sessionId,DateTime startTime)
        {
            try
            {
                CLSExR.Clients[(int)clientId].ConsoleName=consoleName;
                CLSExR.Clients[(int)clientId].ConsoleId=consoleId;
                CLSExR.Clients[(int)clientId].SessionId=sessionId;
                CLSExR.Clients[(int)clientId].StartTime=startTime;
                return true;
            } catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine("StartLog ERROR: "+e.Message);
                return false;
            }
        }

        public bool EndLog(uint clientId,DateTime endTime,TimeSpan totalTime,double totalConsumption)
        {
            try
            {
                CLSExR.Clients[(int)clientId].EndTime=endTime;
                CLSExR.Clients[(int)clientId].TotalTime=totalTime;
                CLSExR.Clients[(int)clientId].TotalConsumption=totalConsumption;
                return true;
            } catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine("StartLog ERROR: "+e.Message);
                return false;
            }
        }
    }
}