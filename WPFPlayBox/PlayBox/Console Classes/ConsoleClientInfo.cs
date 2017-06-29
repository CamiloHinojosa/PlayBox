using System;

namespace PlayBox
{
    [Serializable]
    public class ConsoleClientInformation
    {
        public uint Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string DateOfBirth { get; set; }

        public string DocId { get; set; }

        public ConsoleClientInformation(uint id = 0,string name = "Unknown",string docId = "Unknown",string phoneNumber = "Unknown",string dateOfBirth = "Unknown")
        {
            Id=id;
            Name=name;
            DocId=docId;
            PhoneNumber=phoneNumber;
            DateOfBirth=dateOfBirth;
        }

        public ConsoleClientInformation Copy()
        {
            ConsoleClientInformation output = new ConsoleClientInformation();
            output.Id=Id;
            output.Name=Name;
            output.PhoneNumber=PhoneNumber;
            output.DateOfBirth=DateOfBirth;
            return output;
        }
    }
}