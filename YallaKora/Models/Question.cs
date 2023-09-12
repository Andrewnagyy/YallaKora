using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace YallaKora.Models
{
	public class Question
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string QuestionInfo { get; set; }

		public string Answer { get; set; }

        

    }
}
