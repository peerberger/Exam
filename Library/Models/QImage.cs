using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
	public class QImage
	{
		[Key]
		[Column(Order = 1)]
		public int Id { get; set; }
		[Key]
		[Column(Order = 2)]
		public int ExamId { get; set; }
		public byte[] QuestionImage { get; set; }
	}
}
