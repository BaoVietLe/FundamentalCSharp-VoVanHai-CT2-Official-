
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using System.Security.Claims;
using System.Media;


class Operation //Nơi tạo hình và âm thanh cho các tình huống cụ thể 
{
    public static void nameGame() //Tình huống mở đầu game game
    {
        // Tạo Art cho tiêu đề game
        string[] GoldDigger = new string[] //Tạo mảng chứa Art tiêu đề game  
        {
        @" ██████╗  ██████╗ ██╗     ██████╗     ██████╗ ██╗ ██████╗  ██████╗ ███████╗██████╗ ",
        @"██╔════╝ ██╔═══██╗██║     ██╔══██╗    ██╔══██╗██║██╔════╝ ██╔════╝ ██╔════╝██╔══██╗",
        @"██║  ███╗██║   ██║██║     ██║  ██║    ██║  ██║██║██║  ███╗██║  ███╗█████╗  ██████╔╝",
        @"██║   ██║██║   ██║██║     ██║  ██║    ██║  ██║██║██║   ██║██║   ██║██╔══╝  ██╔══██╗",
        @"╚██████╔╝╚██████╔╝███████╗██████╔╝    ██████╔╝██║╚██████╔╝╚██████╔╝███████╗██║  ██║",
        @" ╚═════╝  ╚═════╝ ╚══════╝╚═════╝     ╚═════╝ ╚═╝ ╚═════╝  ╚═════╝ ╚══════╝╚═╝  ╚═╝",
        };

        Console.ForegroundColor = ConsoleColor.Yellow; //Tô màu vàng cho tiêu đề 
        PrintCentered(GoldDigger, "Yellow"); // Căn giữa cho tiêu đề 
    }
    public static void Congratulate() //Tình huống chiến thắng game 
    {
        //tạo Art cho tiêu đề Winner sau thắng game
        string[] Winner = new string[]
 {
    @"  ██╗    ██╗██╗███╗   ██╗███╗   ██╗███████╗██████╗ ",
    @"  ██║    ██║██║████╗  ██║████╗  ██║██╔════╝██╔══██╗",
    @"  ██║ █╗ ██║██║██╔██╗ ██║██╔██╗ ██║█████╗  ██████╔╝",
    @"  ██║███╗██║██║██║╚██╗██║██║╚██╗██║██╔══╝  ██╔══██╗",
    @"  ╚███╔███╔╝██║██║ ╚████║██║ ╚████║███████╗██║  ██║",
    @"   ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝"
 };

        PrintCentered(Winner, "Green"); //Căn giữa và tô màu xanh cho tiêu đề chiến thắng 
        //tạo âm thanh Winning: Happy Birthday 
        int duration = 400; // Độ dài mỗi nốt nhạc
        int pause = 100; // Khoảng cách giữa các nốt nhạc

        // Giai điệu của "Happy Birthday"
        int[] notes = {
            264, 264, 297, 264, 352, 330, // Happy Birthday to you
            264, 264, 297, 264, 396, 352, // Happy Birthday to you
            264, 264, 528, 440, 352, 330, 297, // Happy Birthday dear [Name]
            466, 466, 440, 352, 396, 352 // Happy Birthday to you
        };

        foreach (int note in notes) //Phát âm thanh theo từng note nhạc
        {
            Console.Beep(note, duration);
            Thread.Sleep(pause);
        }
        Console.WriteLine("Tải bảng xếp hạng....Loading");

    }
    public static void GameOver()
    {
        string[] gameOver = new string[]
        // tạo Art cho Game Over 
        {
            @"  ██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗ ",
            @" ██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗",
            @" ██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝",
            @" ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║██║   ██║██╔══╝  ██╔══██╗",
            @" ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝╚██████╔╝███████╗██║  ██║",
            @"  ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝  ╚═════╝ ╚══════╝╚═╝  ╚═╝",
        };
      
        PrintCentered(gameOver, " Yellow"); //Căn giữa và tô màu vàng cho tiêu đề Game Over
        // Tạo âm thanh Game Over
        Console.Beep(523, 500);
        Console.Beep(587, 500);
        Console.Beep(659, 500);
        Console.Beep(784, 500);
        Console.Beep(880, 500);
        Console.Beep(988, 500);
        Console.Beep(1046, 500);
        Console.Beep(494, 300);
        Console.Beep(523, 300);
        Console.Beep(440, 300);
        Console.Beep(392, 300);
        Console.Beep(440, 200);

        Console.WriteLine("Tải bảng xếp hạng....Loading");
    }

    public static void PrintCentered(string[] text, string color) //Hàm căn giữa và tô màu cho tiêu đề 
    {
        Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color, true);
        //Xác định vị trí giữa 
        int xPos = (Console.BufferWidth - text[0].Length) / 2;
        int yPos = (Console.BufferHeight - text.Length) / 2;
        //Vẽ tiêu đề
        for (int i = 0; i < text.Length; i++)
        {
            Console.SetCursorPosition(xPos, yPos + i); //Đặt con trỏ chuột tại vị trí giữa
            Console.WriteLine(text[i]);
        }

        Console.ResetColor();
    }
}

class starGame
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.OutputEncoding = Encoding.UTF8; //Ngôn ngữ đầu ra bằng Tiếng Việt 

        Operation.nameGame(); // Vẽ màn hình giao điện đầu tiên 
        Console.SetCursorPosition((Console.WindowWidth - 28) / 2, Console.WindowHeight / 2 + 4); //Điều chỉnh con trỏ
        Console.WriteLine("Nhấn phím bất kỳ để tiếp tục...");
        Console.ReadKey(true); // Đợi người chơi bấm phím bất kỳ để tiếp tục
        Console.Clear(); // Xóa màn hình

        // Nội dung yêu cầu nhập tên
        string prompt = "Vui lòng nhập tên của bạn";
        int boxWidth = 50; // Chiều rộng của hộp
        int boxHeight = 10; // Chiều cao của hộp

        // Tính toán vị trí để căn giữa
        int alignLeft = (Console.WindowWidth - boxWidth) / 2;
        int alignTop = (Console.WindowHeight - boxHeight) / 2;

        // Vẽ hộp nhập tên
        Console.SetCursorPosition(alignLeft, alignTop);//Điều chỉnh con trỏ 
        Console.WriteLine(new string('=', boxWidth)); // Vẽ cạnh trên của hộp
        Console.SetCursorPosition(alignLeft + 12, alignTop + 1);
        Console.WriteLine(prompt); // In nội dung yêu cầu nhập tên
        Console.SetCursorPosition(alignLeft + 2, alignTop + 2);
        Console.WriteLine(new string(' ', boxWidth - 4)); // Chỗ trống cho tên
        Console.SetCursorPosition(alignLeft, alignTop + 3);
        Console.WriteLine(new string('=', boxWidth)); // Vẽ cạnh dưới của hộp

        // Nhập tên từ người dùng
        Console.SetCursorPosition(alignLeft + 2, alignTop + 2);
        string playerName = Console.ReadLine();

        // Căn giữa cho các lựa chọn
        string startOption = "Nhấn phím 1. Bắt đầu";
        string exitOption = "Nhấn phím 0. Thoát game";

        // Tính toán vị trí cho các tùy chọn
        int optionAlignTop = alignTop + 5; // Hiển thị dưới ô nhập tên

        // Hiển thị lựa chọn
        Console.SetCursorPosition((Console.WindowWidth - startOption.Length) / 2, optionAlignTop);
        Console.WriteLine(startOption);
        Console.SetCursorPosition((Console.WindowWidth - exitOption.Length) / 2, optionAlignTop + 1);
        Console.WriteLine(exitOption);

        //Vòng lặp tiến hành trò chơi 

        while (true)
        {
            var key = Console.ReadKey(true).Key; //Nhận dữ liệu từ bàn phím
            if (key == ConsoleKey.D1)
            {
                Console.Clear();
                Program.StartGame(playerName); // Bắt đầu trò chơi
                break; // Kết thúc vòng lặp khi bắt đầu game
            }
            else if (key == ConsoleKey.D0)
            {
                Console.Clear();
                Console.WriteLine("Cảm ơn bạn đã chơi! Hẹn gặp lại!");
                break; // Kết thúc chương trình
            }
            else
            {
                Console.SetCursorPosition((Console.WindowWidth - startOption.Length) / 2, optionAlignTop + 3);
                Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhấn 1 để bắt đầu hoặc 0 để thoát.");
            }
        }
    }
}


class Program
{
    static int characterX, characterY; //Biến lưu kích thước nhân vật 
    static List<Point> goldPositions = new List<Point>(); //Danh sách các vị trí được lưu của vàng 
    static List<Point> stonePositions = new List<Point>(); //Danh sách các vị trí được lưu của đá
    static Point diamondPosition; //Vị trí được lưu của kim cương 
    static bool isDiamondPresent = false; //Kiểm tra xem kim cương có còn xuất hiện trên màn hình hay không?
    static int score = 0; //Biến in cho điểm 
    static string playerName; //Biến lưu tên người chơi 
    static int targetScore = 160; // Điểm tối thiểu để thắng
    static int timeLimit = 40; // 40 giây cho mỗi màn chơi
    static List<Player> leaderboard = new List<Player>(); //Danh sách người chơi 
    static int saveCount = 0; // Biến để đếm số lần lưu điểm


    static int characterWidth = 7; // Chiều rộng của nhân vật
    static int characterHeight = 6; // Chiều cao của nhân vật
    static string[] characterArt = new string[] { //Art của nhân vật trong game 
        "      O      ",
        "     /|\\     ",
        "  ⛏ / | \\  ",
        "     / \\     ",
        "    /   \\    ",
        "              "
    };

    // Kích thước của túi vàng
    static int goldWidth = 2; // Chiều rộng
    static int goldHeight = 1; // Chiều cao
    static string goldArt = "💰";

    // Kích thước của đá
    static int stoneWidth = 2; // Chiều rộng
    static string stoneArt = "🪨";

    static int stoneHeight = 1; // Chiều cao
    public static void StartGame(string name)
    {
        playerName = name;
        score = 0;
        timeLimit = 40; // Reset lại thời gian
        Console.Clear();
        Console.CursorVisible = false; //Ẩn con trỏ 
        //Kích thước của màn hình trò chơi được điều chỉnh theo kích thước màn hình máy tính 
        int consoleWidth = Console.WindowWidth;
        int consoleHeight = Console.WindowHeight;

        characterX = (consoleWidth - characterWidth) / 2; //Điều chỉnh vị trí nhân vật theo chiều rộng màn hình 
        characterY = (consoleHeight - characterHeight) / 2; //Điều chỉnh vị trí nhân vật theo chiều cao màn hình

        GenerateGold(10); //Tạo ngẫu nhiên vàng
        GenerateDiamond(); //Tạo ngẫu nhiên kim cương
        GenerateStones(10); //Tạo ngẫu nhiên đá 

        DrawCharacter(characterX, characterY); //Vẽ nhân vật theo kích thước 

        // Khởi động bộ đếm thời gian 40 giây
        Thread timerThread = new Thread(() => CountdownTimer());
        timerThread.Start();
        bool isPlaying = true;

        while (isPlaying)
        {

            // Vòng lặp trò chơi chính
            while (timeLimit > 0)
            {
                MoveCharacter(); // Di chuyển nhân vật theo ý muón người chơi 

                Thread.Sleep(1); // Giảm thời gian để chuyển động mượt hơn
            }

            // Sau khi thời gian kết thúc, kiểm tra điểm
            if (score >= targetScore)
            {
                ShowCongratulation(); // Hiển thị màn chúc mừng sau thắng trò chơi
                Ranking(); //Hiển thị bảng xếp hạng 
                Console.ReadKey(); // Chờ người dùng phản hồi để tắt game 
            }
            else
            {
                ShowGameOver(); // Hiển thị thông báo thua cuộc
                // Hiển thị bảng xếp hạng
                Ranking(); // Hiển thị bảng xếp hạng
                Console.ReadKey(); //Chờ người dùng phản hồi để tắt game
            }
        }


        static void MoveCharacter()
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;

                ClearCharacter(characterX, characterY);

                // Di chuyển nhân vật trái/phải/lên/xuống
                if (key == ConsoleKey.LeftArrow && characterX > 0) //Di chuyển nhân vật sang trái 
                {
                    characterX--; //Vị trí ngang của nhân vật thay đổi 
                }
                else if (key == ConsoleKey.RightArrow && characterX < Console.WindowWidth - characterWidth) //Di chuyển nhân vật sang phải 
                {
                    characterX++; //Vị trí ngang của nhân vật thay đổi
                }

                if (key == ConsoleKey.DownArrow && characterY < Console.WindowHeight - characterHeight) //Di chuyển nhân vật đi xuống 
                {
                    characterY++;//Vị trí dọc của nhân vật thay đổi
                }
                else if (key == ConsoleKey.UpArrow && characterY > 0) //Di chuyển nhân vật đi lên 
                {
                    characterY--; //Vị trí ngang của nhân vật thay đổi
                }

                CheckForGoldCollection(); // Hàm kiểm tra các ảnh hưởng với vàng 
                CheckForDiamondCollection();// Hàm kiểm tra các ảnh hưởng với kim cương
                CheckForStoneCollection(); // Hàm kiểm tra các ảnh hưởng với đá 

                DrawCharacter(characterX, characterY); //Vẽ nhân vật 
            }
        }

        // Bộ đếm thời gian 
        static void CountdownTimer()
        {
            while (timeLimit > 0)
            {
                Thread.Sleep(1000); // Mỗi giây giảm 1 đơn vị
                timeLimit--; //Biến thời gian giảm 
                DrawInfoPanel(); // Cập nhật thông tin điểm số và thời gian
            }
        }
        // Vẽ nhân vật
        static void DrawCharacter(int x, int y)
        {
            for (int i = 0; i < characterHeight; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(characterArt[i]);
            }
        }
        // Xóa và cập nhật mới vị trí nhân vật 
        static void ClearCharacter(int x, int y)
        {
            for (int i = 0; i < characterHeight; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(new string(' ', characterWidth));
            }
        }

        // Tạo hình vàng
        static void GenerateGold(int numGold)
        {
            Random rnd = new Random(); //Tạo random vàng trên màn hình 
            //Xác định mặt trên và mặt dưới của lòng đất để tạo vàng trong khoảng đó 
            int groundTop = Console.WindowHeight / 2;
            int groundBottom = Console.WindowHeight - 3;
            // Tạo số lượng vàng xếp rải rác trên màn hình game 
            for (int i = 0; i < numGold; i++)
            {
                Point goldPosition;
                do
                {
                    int x = rnd.Next(0, Console.WindowWidth - goldWidth);
                    int y = rnd.Next(groundTop, groundBottom);
                    goldPosition = new Point(x, y);
                } while (goldPositions.Contains(goldPosition));
                goldPositions.Add(goldPosition);
                DrawGold(goldPosition);
            }
        }
        // Vẽ vàng 
        static void DrawGold(Point position)
        {
            Console.SetCursorPosition(position.X, position.Y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(goldArt);
            Console.ResetColor();
        }
        // Xóa và cập nhật mới vị trí vàng
        static void ClearGold(Point position)
        {
            Console.SetCursorPosition(position.X, position.Y);
            Console.Write(new string(' ', goldWidth)); // Xóa theo chiều rộng của túi vàng
        }
        // Tạo hình kim cương
        static void GenerateDiamond()
        {
            Random rnd = new Random();
            int groundTop = Console.WindowHeight / 2;
            int groundBottom = Console.WindowHeight - 3;
            // Vị trí kim cương 
            do
            {
                int x = rnd.Next(0, Console.WindowWidth - 1);
                int y = rnd.Next(groundTop, groundBottom);
                diamondPosition = new Point(x, y);
            } while (goldPositions.Contains(diamondPosition) || stonePositions.Contains(diamondPosition)); // Để vị trí kim cương không trùng với vị trí vàng và đá 

            isDiamondPresent = true;
            // vẽ kim cương 
            DrawDiamond(diamondPosition);

            Thread diamondTimerThread = new Thread(() =>
            {
                Thread.Sleep(10000);// Xóa viên kim cương sau 10s đếm ngược
                ClearDiamond(diamondPosition);
                isDiamondPresent = false; //Viên kim cương không còn trên màn hình 
            });
            diamondTimerThread.Start();
        }
        // vẽ kim cương 
        static void DrawDiamond(Point position)
        {
            Console.SetCursorPosition(position.X, position.Y);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("💎");
            Console.ResetColor();
        }
        // Xóa kim cương
        static void ClearDiamond(Point position)
        {
            Console.SetCursorPosition(position.X, position.Y);
            Console.Write(new string(' ', 1)); // Xóa theo chiều rộng của viên kim cương
        }
        //Tạo hình đá
        static void GenerateStones(int numStones)
        {
            Random rnd = new Random();
            int groundTop = Console.WindowHeight / 2;
            int groundBottom = Console.WindowHeight - 3;

            for (int i = 0; i < numStones; i++)
            {
                Point stonePosition;
                do
                {
                    int x = rnd.Next(0, Console.WindowWidth - stoneWidth);
                    int y = rnd.Next(groundTop, groundBottom);
                    stonePosition = new Point(x, y);
                } while (goldPositions.Contains(stonePosition) || stonePositions.Contains(stonePosition));
                stonePositions.Add(stonePosition);
                DrawStone(stonePosition);
            }
        }
        //Vẽ đá
        static void DrawStone(Point position)
        {
            Console.SetCursorPosition(position.X, position.Y);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(stoneArt);
            Console.ResetColor();
        }
        // Xóa và cập nhật mới vị trí đá 
        static void ClearStone(Point position)
        {
            Console.SetCursorPosition(position.X, position.Y);
            Console.Write(new string(' ', stoneWidth)); // Xóa theo chiều rộng của đá
        }

        // Hàm kiểm tra các ảnh hưởng với vàng 
        static void CheckForGoldCollection()
        {
            for (int i = goldPositions.Count - 1; i >= 0; i--)
            {
                Point goldPosition = goldPositions[i];
                if (IsColliding(goldPosition))
                {
                    ClearGold(goldPosition);
                    goldPositions.RemoveAt(i);
                    score += 20; // Thêm điểm cho vàng
                    DrawInfoPanel(); // Cập nhật thông tin điểm số
                }
            }
        }

        // Hàm kiểm tra các ảnh hưởng với kim cương
        static void CheckForDiamondCollection()
        {
            if (isDiamondPresent && IsColliding(diamondPosition))
            {
                ClearDiamond(diamondPosition);
                isDiamondPresent = false;
                score += 100; // Thêm điểm cho viên kim cương
                DrawInfoPanel(); // Cập nhật thông tin điểm số
            }
        }

        // Hàm kiểm tra các ảnh hưởng với đá
        static void CheckForStoneCollection()
        {
            for (int i = stonePositions.Count - 1; i >= 0; i--)
            {
                Point stonePosition = stonePositions[i];
                if (IsColliding(stonePosition))
                {
                    ClearStone(stonePosition);
                    stonePositions.RemoveAt(i);
                    score -= 5; // Trừ điểm khi chạm vào đá
                    DrawInfoPanel(); // Cập nhật thông tin điểm số

                }
            }
        }

        // Kiểm tra vật phẩm có đang được thu thập từ người chơi hay không?
        static bool IsColliding(Point position)
        {
            return characterX < position.X + goldWidth && characterX + characterWidth > position.X &&
                   characterY < position.Y + goldHeight && characterY + characterHeight > position.Y;
        }

        static void DrawInfoPanel() //Vẽ bảng thông tin
        {
            Console.SetCursorPosition(0, 0); // Di chuyển lên góc trái
            Console.WriteLine($"Điểm số: {score}  Thời gian còn lại: {timeLimit} s"); //Cập nhật điểm số và thời gian 
        }

        static void ShowCongratulation() //Màn hình chúc mừng 
        {
            Console.Clear();
            Operation.Congratulate(); //Chạy hàm tạo hình chúc mừng ở trên 

            // Thông báo chiến thắng
            string congratsMessage = $"Chúc mừng {playerName}! Bạn đã chiến thắng với điểm số: {score}!";
            //Đặt ở giữa màn hình
            int xPos = (Console.WindowWidth - congratsMessage.Length) / 2;
            // Vị trí yPos sẽ là vài dòng dưới dòng chữ "Winner"
            int yPos = (Console.WindowHeight / 2) + 4; // Tùy chỉnh khoảng cách bằng cách tăng giá trị

            Console.SetCursorPosition(xPos, yPos);
            Console.WriteLine(congratsMessage);

            // Đợi một chút trước khi làm mới màn hình
            Thread.Sleep(2000); // 2 giây
        }

        static void ShowGameOver() //Màn hình thất bại 
        {
            Console.Clear();
            Operation.GameOver();//Chạy hàm tạo hình thất bại ở trên 

            // Thông báo điểm số cuối cùng
            string gameOverMessage = $"Điểm số cuối cùng của bạn: {score}";
            //Đặt ở giữa màn hình
            int xPos = (Console.WindowWidth - gameOverMessage.Length) / 2;
            // Vị trí yPos sẽ là vài dòng dưới dòng chữ "Game Over"
            int yPos = (Console.WindowHeight / 2) + 4; // Tùy chỉnh khoảng cách bằng cách tăng giá trị
            Console.SetCursorPosition(xPos, yPos);
            Console.WriteLine(gameOverMessage);
            // Đợi một chút trước khi làm mới màn hình
            Thread.Sleep(2000); // 2 giây
        }
    }


    private static readonly string leaderboardFile = "leaderboard.txt"; //Trích file lưu trữ bảng xếp hạng 
    static void Ranking()
    {

        try
        {
            SaveScore(playerName, score); //Hàm lưu điểm người chơi 
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi lưu điểm: {ex.Message}"); //Trường hợp lưu điểm lỗi 
        }

        List<Player> leaderboard = null; //Khi danh sách người chơi không có dữ liệu 

        try
        {
            leaderboard = LoadLeaderboard(); //Tải dữ liệu bảng xếp hạng 
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi tải bảng xếp hạng: {ex.Message}");
        }

        if (leaderboard != null) //Kiểm tra xem bảng xếp hạng có dữ liệu hay không?
        {
            try
            {
                Leaderboard.Display(leaderboard); //Chiếu bảng xếp hạng lên màn hình 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi hiển thị bảng xếp hạng: {ex.Message}"); //Trường hợp không thể hiển thị bảng xếp hạng 
            }
        }
    }

    public static void SaveScore(string playerName, int score)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(leaderboardFile, true))
            //Đảm bảo rằng đối tượng được tạo ra bên trong khối using sẽ được giải phóng tài nguyên khi khối này kết thúc, ngay cả khi có ngoại lệ xảy ra. 
            //Điều này giúp quản lý tài nguyên một cách hiệu quả và tránh rò rỉ tài nguyên
            //StreamWriter là một lớp trong .NET Framework được sử dụng để ghi các ký tự vào một tệp tin theo một định dạng cụ thể.
            {
                writer.WriteLine($"{playerName},{score}");
            }

            saveCount++; // Tăng biến đếm lưu điểm
            if (saveCount >= 10) // Nếu đã lưu 10 lần
            {
                score = 0; // Khởi động lại điểm
                saveCount = 0; // Đặt lại biến đếm
                File.WriteAllText(leaderboardFile, ""); // Xóa nội dung tệp bảng xếp hạng
                Console.WriteLine("Điểm đã được khởi động lại và bảng xếp hạng đã được xóa.");
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Không thể lưu điểm vào file.", ex); //Trường hợp lưu điểm lỗi 
        }
    }

    public static List<Player> LoadLeaderboard() //Danh sách người chơi lưu vào bảng xếp hạng 
    {
        List<Player> leaderboard = new List<Player>();

        try
        {
            if (File.Exists(leaderboardFile)) //Đọc file lấy dữ liệu bảng xếp hạng 
            {
                var lines = File.ReadAllLines(leaderboardFile);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 2 && int.TryParse(parts[1], out int score))
                    {
                        leaderboard.Add(new Player(parts[0], score));
                    }
                    else
                    {
                        throw new FormatException("Dòng không hợp lệ trong file bảng xếp hạng."); //Lỗi không thể đọc dữ liệu trong file 
                    }
                }
                leaderboard.Sort((p1, p2) => p2.Score.CompareTo(p1.Score)); //Sắp xếp theo thứ tự từ cao đến thấp 
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Lỗi khi tải bảng xếp hạng từ file.", ex); //Trường hợp không thể lấy dữ liệu xếp hạng từ file 
        }

        return leaderboard;
    }
}



class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class Player
{
    public string Name { get; set; }
    public int Score { get; set; }

    public Player(string name, int score)
    {
        Name = name;
        Score = score;
    }

}

class Leaderboard
{
    public static void Display(List<Player> players) //Vẽ bảng xếp hạng 
    {
        try
        {
            Console.Clear();

            // Vẽ tiêu đề ranking 
            string[] leaderboardTitle = new string[]
            {
               @"   _______    ______   __    __  __    __  ______  __    __   ______    ",
               @"  |       \  /      \ |  \  |  \|  \  /  \|      \|  \  |  \ /      \   ",
               @"  | $$$$$$$\|  $$$$$$\| $$\ | $$| $$ /  $$ \$$$$$$| $$\ | $$|  $$$$$$\  ",
               @"  | $$__| $$| $$__| $$| $$$\| $$| $$/  $$   | $$  | $$$\| $$| $$ __\$$  ",
               @"  | $$    $$| $$    $$| $$$$\ $$| $$  $$    | $$  | $$$$\ $$| $$|    \  ",
               @"  | $$$$$$$\| $$$$$$$$| $$\$$ $$| $$$$$\    | $$  | $$\$$ $$| $$ \$$$$  ",
               @"  | $$  | $$| $$  | $$| $$ \$$$$| $$ \$$\  _| $$_ | $$ \$$$$| $$__| $$  ",
               @"  | $$  | $$| $$  | $$| $$  \$$$| $$  \$$\|   $$ \| $$  \$$$ \$$    $$  ",
               @"   \$$   \$$ \$$   \$$ \$$   \$$ \$$   \$$ \$$$$$$ \$$   \$$  \$$$$$$   ",

            };

            int centerTitleX = (Console.WindowWidth - leaderboardTitle[0].Length) / 2;
            int titleStartY = 1;
            Console.ForegroundColor = ConsoleColor.Cyan;

            for (int i = 0; i < leaderboardTitle.Length; i++)
            {
                Console.SetCursorPosition(centerTitleX, titleStartY + i);
                Console.WriteLine(leaderboardTitle[i]);
            }
            //Hiển thị bảng xếp hạng theo thứ tự từ cao đến thấp 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, titleStartY + leaderboardTitle.Length + 2);
            Console.WriteLine($"{"Pos",-6} | {"Player",-20} | {"Score",5}");

            Console.ForegroundColor = ConsoleColor.White;

            int position = 1;
            int rowY = titleStartY + leaderboardTitle.Length + 4;

            for (int i = 0; i < players.Count && i < 10; i++)
            {
                Console.SetCursorPosition((Console.WindowWidth - 50) / 2, rowY++);
                Console.WriteLine($"{position++,6} | {players[i].Name,-20} | {players[i].Score,5}");
            }

            Console.ResetColor();
        }
        catch (Exception ex)
        {
            throw new Exception("Lỗi khi hiển thị bảng xếp hạng trên Console.", ex); //Lỗi không thể hiển thị bảng xếp hạng 
        }
    }

}












