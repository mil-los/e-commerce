namespace API.Errors
{
    public class ApiValitationErrorResponse : ApiResponse
    {
        public ApiValitationErrorResponse() : base(400)
        {

        }

        public IEnumerable<string> Errors { get; set; }
    }
}