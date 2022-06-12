using System;

namespace DotNET_Core_MVC_Image_Upload_and_Retrieve.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
