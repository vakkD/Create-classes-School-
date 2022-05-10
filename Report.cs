using System;
using System.Collections.Generic;

public class Report
{
	public String Name{get; set;}
	public int schoolId;
	public Student studentName{get; set;}
	public Teacher teacherName{get; set;}
	public List<Grade> grades = new List<Grade>();
}