using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
	public class QImage
	{
		public int Id { get; set; }
		public int ExamId { get; set; }
		public byte[] QuestionImage { get; set; }
	}
}
