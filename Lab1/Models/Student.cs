using System;
namespace Lab1.Models
{
	public class Student
	{
		public int Id { get; set; }//Ma sinh vien
		public string? Name { get; set; }//Ho ten
		public string? Email { get; set; }//Email
		public string? Password { get; set; }//Mat khau
		public Branch? Branch { get; set; }//Nganh hoc
		public Gender? Gender { get; set; }//Gioi tinh
		public bool IsRegular { get; set; }//He: true-chinh qui, false-phi cq
		public string? Address { get; set; }//Dia chi
		public DateTime DateOfBorth { get; set; }//Ngay sinh
	}
}

