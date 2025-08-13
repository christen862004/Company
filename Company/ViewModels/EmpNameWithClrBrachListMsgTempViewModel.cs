namespace Company.ViewModels
{
    public class EmpNameWithClrBrachListMsgTempViewModel
    {
        //Send Some Property from Model andd Hide table Structure
        public int EmpId { get; set; }
        public string EmpFullName { get; set; }

        //Add Extra Info
        public int Temp { get; set; }
        public string Msg { get; set; }
        public string Color { get; set; }
        public List<string> Branches { get; set; }

        //Get Info From another Model
    }
}
