using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace KTPM_53_Trieu
{
    public partial class FormWebDriverKTPM_53_Trieu : Form
    {
        public FormWebDriverKTPM_53_Trieu()
        {
            InitializeComponent();
        }


        private void btnTaoMoi_53_Trieu_Click(object sender, EventArgs e) // Chức năng 1: Tạo 1 trận đấu với máy
        {
            //Đóng màn hình đen khi chạy 
            ChromeDriverService chrome_53_Trieu = ChromeDriverService.CreateDefaultService();
            chrome_53_Trieu.HideCommandPromptWindow = true;


            // Khởi tạo trình duyệt Chrome
            IWebDriver chromedriver_53_Trieu = new ChromeDriver(chrome_53_Trieu);


            // Mở trang web 
            chromedriver_53_Trieu.Navigate().GoToUrl("https://play.xiangqi.com/");

            // Set thời gian chờ cho trang web load
            chromedriver_53_Trieu.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


            //Click vào nút Join Lobby
            IWebElement C_buttonLobby_53_Trieu = chromedriver_53_Trieu.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/div[2]/button"));
            C_buttonLobby_53_Trieu.Click();

            System.Threading.Thread.Sleep(1000);
            // Click vào nút Create name
            IWebElement C_buttonnew_53_Trieu = chromedriver_53_Trieu.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[1]/div/div/div[2]/div/div[2]/div[1]/div/button[2]"));
            C_buttonnew_53_Trieu.Click();

            System.Threading.Thread.Sleep(1000);
            //click vào option Newbie
            IWebElement C_buttonskill_53_Trieu = chromedriver_53_Trieu.FindElement(By.XPath("/html/body/div[4]/div/div/div/div/div/ul/li[1]"));
            C_buttonskill_53_Trieu.Click();


            System.Threading.Thread.Sleep(1000);
            //click vào nút Play As Guest
            IWebElement C_buttonsgues_53_Trieu = chromedriver_53_Trieu.FindElement(By.XPath("/html/body/div[4]/div/div/div/div/div/button[1]"));
            C_buttonsgues_53_Trieu.Click();

            System.Threading.Thread.Sleep(1000);
            try
            {
                // Tìm thông báo
                IWebElement toastrElement_53_Trieu = chromedriver_53_Trieu.FindElement(By.CssSelector(".toastr\\.xi-main-notification"));

                // Nếu thông báo được tìm thấy, sử dụng JavaScript để ẩn nó
                ((IJavaScriptExecutor)chromedriver_53_Trieu).ExecuteScript("arguments[0].style.display = 'none';", toastrElement_53_Trieu);
            }
            catch (NoSuchElementException)
            {
                //click bật option Private
                IWebElement C_buttonsspan_53_Trieu = chromedriver_53_Trieu.FindElement(By.CssSelector("label[for='isPrivate']"));
                C_buttonsspan_53_Trieu.Click();
            }



            System.Threading.Thread.Sleep(1000);
            //Xử lý kéo thanh Move Timer (Minutes)
            IWebElement inputElement_53_Trieu = chromedriver_53_Trieu.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div/div/div/div[2]/div/div[2]/div[2]/div/div/input"));
            //gán giá trị '5' cho thuộc tính 'value' của phần tử inputElement(đặt giá trị của trường nhập liệu thành '5')
            ((IJavaScriptExecutor)chromedriver_53_Trieu).ExecuteScript("arguments[0].value = '5';", inputElement_53_Trieu);
            //tạo ra một sự kiện 'input' và gửi nó đến phần tử inputElement
            ((IJavaScriptExecutor)chromedriver_53_Trieu).ExecuteScript("var event = new Event('input', { bubbles: true }); arguments[0].dispatchEvent(event);", inputElement_53_Trieu);


            System.Threading.Thread.Sleep(1000);
            //Click vào nút PLAY
            IWebElement C_buttonplay_53_Trieu = chromedriver_53_Trieu.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[1]/div/div/div[2]/div/button"));
            C_buttonplay_53_Trieu.Click();


            System.Threading.Thread.Sleep(1000);
            //Click vào nút Vs.ComPuTer
            IWebElement C_PlayCom_53_Trieu = chromedriver_53_Trieu.FindElement(By.CssSelector("#game-area > div.ReactModalPortal > div > div > div > div > div > button"));
            C_PlayCom_53_Trieu.Click();

            System.Threading.Thread.Sleep(1000);
            //Xữ lý chọn Avata cho nhân vật

            IList<IWebElement> c_ViewaAvt_53_Trieu = chromedriver_53_Trieu.FindElements(By.ClassName("bot-item"));// Lấy ra danh sách Avata
            IWebElement thirdElement_53_Trieu = c_ViewaAvt_53_Trieu[2];//Lấy đối tượng Avata số 3
            thirdElement_53_Trieu.Click(); // Click vào đối tượng đó 

            System.Threading.Thread.Sleep(1000);
            //Chọn option Choose a side:  Ở đây ta chọn option Random
            IWebElement x_side_53_Trieu = chromedriver_53_Trieu.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div/div/div[2]/div/div[2]/div[2]/div/button[2]"));
            x_side_53_Trieu.Click();

            System.Threading.Thread.Sleep(1000);
            //Click vào nút PLAY để tạo trận đấu    
            IWebElement C_Play_53_Trieu = chromedriver_53_Trieu.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div/div/div[2]/div/div[3]/button[1]"));
            C_Play_53_Trieu.Click();

            Thread.Sleep(5000);

            // Phần tử của con tốt 
            IWebElement pawnElement1_53_Trieu = chromedriver_53_Trieu.FindElement(By.CssSelector("#game-grid > div:nth-child(7) > div.square.\\34 -g > div > div > div"));

            // Phần tử của ô đích duy chuyển con tốt đến 
            IWebElement destinationCell1_53_Trieu = chromedriver_53_Trieu.FindElement(By.CssSelector("#game-grid > div:nth-child(6) > div.square.\\35 -g"));

            // Tạo một chuỗi các thao tác chuột
            //Thao tác 1
            Actions actions1_53_Trieu = new Actions(chromedriver_53_Trieu);
            // Thực hiện thao tác click vào con cờ
            actions1_53_Trieu.Click(pawnElement1_53_Trieu);
            // Thực hiện thao tác duy chuyển chuột đến vị trí con cờ muốn đến
            actions1_53_Trieu.MoveToElement(destinationCell1_53_Trieu);
            // Thực hiện thao tác click để con cờ đến vị trí đó
            actions1_53_Trieu.Click();
            // Kết thúc chuỗi các thao tác chuột và thực hiện chúng
            actions1_53_Trieu.Build().Perform();

            Thread.Sleep(3000);
            //Đóng trình duyệt
            chromedriver_53_Trieu.Quit();
        }

        private void btnBinhLuan_53_Trieu_Click(object sender, EventArgs e)// CHỨC NĂNG 2: Đăng nhập và bình luận 1 trận đâú
        {

            //Đóng màn hình đen khi chạy 
            ChromeDriverService chrome_53_Trieu = ChromeDriverService.CreateDefaultService();
            chrome_53_Trieu.HideCommandPromptWindow = true;

            // Khởi tạo trình duyệt Chrome
            IWebDriver chromedriver_53_Trieu = new ChromeDriver(chrome_53_Trieu);

            // Mở trang web 
            chromedriver_53_Trieu.Navigate().GoToUrl("https://play.xiangqi.com/");

            // Set thời gian chờ cho trang web load
            chromedriver_53_Trieu.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);

            //Sử dụng name để điền thông tin đăng nhập 
            IWebElement c_name_53_Trieu = chromedriver_53_Trieu.FindElement(By.Name("emailOrUsername"));
            c_name_53_Trieu.SendKeys("phanhoangtrieunk@gmail.com");
            IWebElement c_pass_53_Trieu = chromedriver_53_Trieu.FindElement(By.Name("password"));
            c_pass_53_Trieu.SendKeys("12345678");

            Thread.Sleep(2000);
            // Sử dụng XPath để thực hiện click vào nút Sign In để đăng nhập
            IWebElement x_buttonLogin_53_Trieu = chromedriver_53_Trieu.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div/div[2]/form/button"));
            x_buttonLogin_53_Trieu.Click();

            Thread.Sleep(2000);
            // Sử dụng CssSelector để thực hiện click vào nut Menu bên tay trái phía trên cùng màn hình
            IWebElement e_Menu_53_Trieu = chromedriver_53_Trieu.FindElement(By.CssSelector("#app > div:nth-child(1) > div.Navbar__NavBar-sc-1iudcxe-0.MWABk > div.drawer-logo-button > button"));
            e_Menu_53_Trieu.Click();

            Thread.Sleep(2000);
            // Sử dụng XPath để thực hiện Click vào Watch 
            IWebElement e_Swatch_53_Trieu = chromedriver_53_Trieu.FindElement(By.XPath("/html/body/div[1]/div[1]/aside/nav/a[2]"));
            e_Swatch_53_Trieu.Click();

            while (true) // Thực hiện 1 vòng lặp tìm kiếm 1 trận đấu và nhấp vào nút view để vào xem
            {
                // Tìm nút với CSS Selector đã chỉ định
                IWebElement button_53_Trieu = chromedriver_53_Trieu.FindElement(By.CssSelector("#app > div:nth-child(1) > div.Wrapper-sc-1vh4pck-0.faGlak > div > div > div > ul > li:nth-child(1) > div > ul > li:nth-child(2) > button > span"));

                // Kiểm tra xem nút có hiển thị không
                if (button_53_Trieu.Displayed)
                {
                    // Nhấp vào nút
                    button_53_Trieu.Click();
                    break;
                }
                Thread.Sleep(1000); // Dừng lại 1 giây rồi thực hiện lại vòng lặp
            }

            Thread.Sleep(1000);
            //Thực hiện nhập tin nhắn vào Box Chat 
            IWebElement i_chat_53_Trieu = chromedriver_53_Trieu.FindElement(By.Id("chat-input"));
            i_chat_53_Trieu.SendKeys("Great");

            Thread.Sleep(1000);
            //Nhấp vào nút sent để gửi tin nhắn 
            IWebElement c_sent_53_Trieu = chromedriver_53_Trieu.FindElement(By.ClassName("send-button"));
            c_sent_53_Trieu.Click();

            Thread.Sleep(3000);
            // Đóng trình duyệt
            chromedriver_53_Trieu.Quit();

        }
    }
}
