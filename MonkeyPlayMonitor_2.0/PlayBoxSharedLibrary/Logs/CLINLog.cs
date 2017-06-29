using System;

namespace PlayBoxSharedLibrary
{
    [Serializable]
    public class CLINLog:Log
    {
        public string PhoneNumber { get; set; }
        public string DocId { get; set; }
        public string DateOfBirth { get; set; }
        public string ClientName { get; set; }

        public CLINLog(uint id,string clientName,string docId,string phoneNumber,string dateOfBirth)
        {
            Id=id;
            ClientName=clientName;
            DocId=docId;
            PhoneNumber=phoneNumber;
            DateOfBirth=dateOfBirth;
            Name="Client Information Log";
            Type="CLINxL";
            Date=DateTime.Now;
        }
    }
}