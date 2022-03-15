using NUnit.Framework;
using LAB_3_3;

namespace zTest3
{
    public class Tests
    {

        [Test]
        public void DayWeek1()
        {
            DateService el = new DateService();
            string actual = el.GetDayOfWeek("17.03.2022");
            string expected = "�������";
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void DayWeek2()
        {
            DateService el = new DateService();
            string actual = el.GetDayOfWeek("21.11.2022");
            string expected = "�����������";
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void DaysBetween()
        {
            DateService el = new DateService();
            int actual = el.DaysFromCurrent(20, 3, 2022);
            //���� ���� ����������� ������ �� ������ 15.03.2022 � ����� � ���������� ��� �� ���������.
            int expected = 5;
            Assert.AreEqual(actual, expected);
        }
    }
}