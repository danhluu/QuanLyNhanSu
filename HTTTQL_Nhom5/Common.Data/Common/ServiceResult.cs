using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Common
{
    public class ServiceResult
    {
        /// <summary>
        /// true: thành công, false: thất bại
        /// </summary>
        public bool Success { get; set; }

        public object Data { get; set; }

        public String Code { get; set; }

        public ServiceResult()
        {
            Success = true;
        }
    }
}
