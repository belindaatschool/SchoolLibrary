namespace SchoolLibrary
{
    public class Date
    {
        int year;
        int month;
        int day;

        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        //פעולה בונה מעתיקה
        public Date(Date date)
        {
            year = date.year;
            month = date.month;
            day = date.day;
        }

        //פעולות מאחזרות
        public int GetYear() { return year; }
        public int GetMonth() { return month; }
        public int GetDay() { return day; }

        //פעולות קובעות
        public void SetYear(int year) { this.year = year; }
        public void SetMonth(int month) { this.month = month; }
        public void setDay(int day) { this.day = day; }

        //פעולת תאור העצם
        public override string ToString()
        {
            return this.day + "/" + this.month + "/" + this.year;
        }
    }
}