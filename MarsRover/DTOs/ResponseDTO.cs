using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.DTOs
{
    public class ResponseDTO
    {
        public ResponseDTO() { }
        public object Item { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}
