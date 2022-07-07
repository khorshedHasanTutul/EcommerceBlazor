using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebAsmb.Shared
{
	public class ServiceResponse<T>
	{
		public T? Data { get; set; }
		public bool status { get; set; } = true;
		public string message { get; set; } = string.Empty;
    }
}