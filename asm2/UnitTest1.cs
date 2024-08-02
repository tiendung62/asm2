namespace asm2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(3,5,8)]
        [TestCase(3, 8, 11)]
        [TestCase(3, 4, 8)]
        [TestCase(-11, 1000, 989)]
        [TestCase(23, 3, 26)]
        [TestCase(100, 5, 105)]
        [TestCase(28, 7, 35)]
        [TestCase(3.5, -11, -7.5)]
        [TestCase(-12, 22, 10)]
        [TestCase(100, 12, 112)]
        public void tong(double a,double b,double tong)
        {
            if(check2so(a) == true && check2so(b) == true)
            {
                var abc = tong2so(a, b);
                Assert.AreEqual(abc, tong);
            }
            else
            {
                throw new Exception("so nhap vao khong phai so nguyen");
            }
        }
        public double tong2so(double a,double b)
        {
            return a + b;
        }
        public bool check2so(double a)
        {
            if (a % 1 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        [Test]
        [TestCase(3,6,18)]
        [TestCase(2, 6, 12)]
        [TestCase(2.5, 4, 10)]
        [TestCase(3, 6, 12)]
        [TestCase(4, 6, 24)]
        [TestCase(6, 6, 36)]
        [TestCase(13, 10, 130)]
        [TestCase(3, 6, 18)]
        [TestCase(3, 6, 18)]
        [TestCase(3, 6, 18)]
        [TestCase(3, 6, 18)]
        public void tich(double a,double b,double tich)
        {
            if (check2so(a) == true && check2so(b) == true)
            {
                var abc = tich2so(a, b);
                Assert.AreEqual(abc, tich);
            }
            else
            {
                throw new Exception("so nhap vao khong phai so nguyen");
            }
        }
        public double tich2so(double a, double b)
        {
          return a * b;

        }
        [Test]
        [TestCase(5,3,2)]
        [TestCase(100,3,97)]
        [TestCase(13, 5, 8)]
        [TestCase(23, 8, 15)]
        [TestCase(100, 4, 96)]
        [TestCase(-11, 1000, -1011)]
        [TestCase(23, 3, 20)]
        [TestCase(100, 5, 95)]
        [TestCase(28, 7, 21)]
        [TestCase(3.5, -11, -7.5)]
        [TestCase(-12, 22, 10)]
        [TestCase(100, 12, 112)]
        public void hieu(double a,double b,double hieu)
        {
            if (check2so(a) == true && check2so(b) == true)
            {
                var abc = hiue2so(a, b);
                Assert.AreEqual(abc, hieu);
            }
            else
            {
                throw new Exception("so nhap vao khong phai so nguyen");
            }
        }
        public double hiue2so(double a,double b)
        {
            return a - b;
        }
        [Test]
        [TestCase(new double[] { 1.0, 2.0, 3.0 }, 2.0)]
        [TestCase(new double[] { -1.0, -2.0, -3.0 }, -2.0)]
        [TestCase(new double[] { 3,4,5 }, 4)]
        [TestCase(new double[] { 5.5, 6.5, 7.5 }, 6.5)]
        [TestCase(new double[] { -1.0, 1.0 }, 0.0)]
        public void tbc(double[] numbers, double expectedAverage)
        {
            List<double> numberList = new List<double>(numbers);
            if (numbers.All(num => CheckNumber(num)))
            {
                double result = CalculateAverage(numberList);
                Assert.AreEqual(expectedAverage, result, 0.0001);
            }
            else
            {
                throw new Exception("nhap so khong dung");
            }
        }
        public static double CalculateAverage(List<double> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("khong dc de trong");
            }

            return numbers.Average();
        }
        public static bool CheckNumber(double number)
        {
            return number.GetType() == typeof(double);
        }
        public void xuat1phantu()
        {

        }
        public List<sinhvien> sinhviens = new List<sinhvien>();
        [Test]
        [TestCase("3", "dung", "lop02", "loptoan", "020")]
        [TestCase("", "dung", "lop02", "loptoan", "020")]
        [TestCase("-2", "d", "lop02", "loptoan", "020")]
        [TestCase("3", "dung", "lop02", "loptoan", "020")]
        [TestCase("1000", "dung", "lop02", "loptoan", "020")]
        [TestCase("7", "dung", "lop02", "loptoan", "020")]
        [TestCase("18", "dung", "lop02", "loptoan", "020")]
        [TestCase("-22", "dung", "lop02", "loptoan", "020")]
        [TestCase("0", "dung", "lop02", "loptoan", "020")]
        public void addmaytinh(string id, string hoten, string malop, string tenlop, string masv )

        {
            bool check = false;
            if (Convert.ToInt32(id) < 1 || Convert.ToInt32(id) > 100)
            {
                throw new ArgumentException("id k hopwj le");

            }
            if (checkid(id))
            {
                check = true;
            }
            if (hoten.Length < 2 || hoten.Length > 30)
            {
                throw new ArgumentException(" ten mt k hop le");
            }
            if (!checkid(id))
            {
                sinhviens.Add(new sinhvien(id, hoten, malop, tenlop, masv));

            }
            Assert.That(check.Equals(false), " id da ton tai");
        }
        private bool checkid(string id)
        {
            if (sinhviens.FirstOrDefault(x => x.id == id) != null) { return true; }
            return false;

        }
    }
}