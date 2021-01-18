namespace Models
{
    public class ApiException
    {
        public ApiException(int statuCode, string message = null, string detaild = null)
        {
            StatuCode = statuCode;
            Message = message;
            Detaild = detaild;
        }

        public int StatuCode { get; }
        public string Message { get; }
        public string Detaild { get; }
    }
}