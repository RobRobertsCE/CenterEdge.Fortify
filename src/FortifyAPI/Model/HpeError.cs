using System.Collections.Generic;

namespace FortifyAPI.Model
{
    public class HpeError
    {
        public string message { get; set; }
        public int errorCode { get; set; }
    }

    public class HpeErrorResponse
    {
        public List<HpeError> errors { get; set; }
    }

}
