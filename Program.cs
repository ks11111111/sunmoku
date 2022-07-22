using System;

namespace sunmoku
{
    class Program
    {
        static void Main(string[] args)
        {
            int b_height = 0; //黒の時の縦変数
            int b_width = 0; //黒の時の横変数
            int w_height = 0; //白の時の縦変数
            int w_width = 0; //白の時の横変数
            string[,] ban = new string[3,3]{{" "," "," "},{" "," "," "},{" "," "," "}};
            int b_while1 = 0;
            int w_while1 = 0;

            
            //開始のコメント
            Console.WriteLine("三目並べを開始します");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("先行と後攻を決めてください（先行：黒、後攻：白）");
            System.Threading.Thread.Sleep(1000);

            for(int i = 0; i <=5 ; i++){
                if(i==5){
                    Console.Write("ゲームを終了します");
                    Environment.Exit(0);
                }
                Console.Write("決まったら「決定」と入力してください：");
                var OK = Console.ReadLine();
                if(OK!="決定"){
                    Console.WriteLine("入力に誤りがあります、再度入力してください");
                    continue;
                }
                else{
                    break;
                }
            }
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("ゲームを開始します");
            System.Threading.Thread.Sleep(1000);
            System.Threading.Thread.Sleep(1000);


            for(int r = 0; r <=4 ; r++){

                //黒の手番
                while(b_while1 == 0){
                    //置く場所の入力
                    Console.Write("黒の手番です>>");
                    var line = Console.ReadLine();
                    if(!(line.Contains(","))){
                        Console.WriteLine("「〇,〇」の形で入力してください");
                        continue;
                    }
                    var Data = line.Split(',');
                    //if(Data[0]!="0"||Data[0]!="1"||Data[0]!="2"||Data[1]!="0"||Data[1]!="1"||Data[1]!="2"){
                    //    Console.WriteLine("「〇,〇」(0~2)の形で入力してください");
                    //    continue;
                    //}

                    b_height = int.Parse(Data[0]);
                    b_width = int.Parse(Data[1]);

                    if(b_width > 2 || b_height > 2){
                        Console.WriteLine("指定の場所は盤面外です");
                        Console.WriteLine("もう一度入力してください");
                        continue;
                    }

                    if(ban[b_height,b_width] == " "){
                        ban[b_height,b_width] = "b";
                        b_while1 = 1;
                    }
                    else{
                        Console.WriteLine("すでにその場所には碁石が置かれています");
                        Console.WriteLine("もう一度入力してください");
                        continue;
                    }
                }

                //盤面の表示
                Console.WriteLine("| {0} | {1} | {2} |" ,ban[0,0],ban[0,1],ban[0,2]);
                Console.WriteLine("| {0} | {1} | {2} |" ,ban[1,0],ban[1,1],ban[1,2]);
                Console.WriteLine("| {0} | {1} | {2} |" ,ban[2,0],ban[2,1],ban[2,2]);

                //勝敗ジャッジ
                if (ban[0,0] == "b"&&ban[0,1] == "b"&&ban[0,2] == "b"){
                    Console.Write("黒の勝利です!");
                    Environment.Exit(0);
                }
                else if(ban[1,0] == "b"&&ban[1,1] == "b"&&ban[1,2] == "b"){
                    Console.Write("黒の勝利です!");
                    Environment.Exit(0);
                }
                else if(ban[2,0] == "b"&&ban[2,1] == "b"&&ban[2,2] == "b"){
                    Console.Write("黒の勝利です!");
                    Environment.Exit(0);
                }
                else if(ban[0,0] == "b"&&ban[1,0] == "b"&&ban[2,0] == "b"){
                    Console.Write("黒の勝利です!");
                    Environment.Exit(0);
                }
                else if(ban[0,1] == "b"&&ban[1,1] == "b"&&ban[2,1] == "b"){
                    Console.Write("黒の勝利です!");
                    Environment.Exit(0);
                }
                else if(ban[0,2] == "b"&&ban[1,2] == "b"&&ban[2,2] == "b"){
                    Console.Write("黒の勝利です!");
                    Environment.Exit(0);
                }
                else if(ban[0,0] == "b"&&ban[1,1] == "b"&&ban[2,2] == "b"){
                    Console.Write("黒の勝利です!");
                    Environment.Exit(0);
                }
                else if(ban[0,2] == "b"&&ban[1,1] == "b"&&ban[2,0] == "b"){
                    Console.Write("黒の勝利です!");
                    Environment.Exit(0);
                }

                b_while1 = 0;


                //盤面が全て埋まった時の終了
                if(r == 4){
                    Console.Write("盤面が全て埋まったため終了します。");
                    Environment.Exit(0);
                }


                //白の手番
                while(w_while1 == 0){
                    //置く場所の入力
                    Console.Write("白の手番です>>");
                    var line1 = Console.ReadLine();
                    if(!(line1.Contains(","))){
                        Console.WriteLine("「〇,〇」の形で入力してください");
                        continue;
                    }
                    var Data1 = line1.Split(',');
                    //if(Data1[0]!="0"||Data1[0]!="1"||Data1[0]!="2"||Data1[1]!="0"||Data1[1]!="1"||Data1[1]!="2"){
                    //    Console.WriteLine("「〇,〇」(0~2)の形で入力してください");
                    //    continue;
                    //}
                    w_height = int.Parse(Data1[0]);
                    w_width = int.Parse(Data1[1]);

                    if(w_width > 2 || w_height > 2){
                        Console.WriteLine("指定の場所は盤面外です");
                        Console.WriteLine("もう一度入力してください");
                        continue;
                    }

                    if(ban[w_height,w_width] == " "){
                        ban[w_height,w_width] = "w";;
                        w_while1 = 1;
                    }
                    else{
                        Console.WriteLine("すでにその場所には碁石が置かれています");
                        Console.WriteLine("もう一度入力してください");
                        continue;
                    }
                }

                //盤面の表示
                Console.WriteLine("| {0} | {1} | {2} |" ,ban[0,0],ban[0,1],ban[0,2]);
                Console.WriteLine("| {0} | {1} | {2} |" ,ban[1,0],ban[1,1],ban[1,2]);
                Console.WriteLine("| {0} | {1} | {2} |" ,ban[2,0],ban[2,1],ban[2,2]);

                //勝敗ジャッジ
                if (ban[0,0] == "w"&&ban[0,1] == "w"&&ban[0,2] == "w"){
                    Console.Write("白の勝利です!");
                    Environment.Exit(0);
                } 
                else if(ban[1,0] == "w"&&ban[1,1] == "w"&&ban[1,2] == "w"){
                    Console.Write("白の勝利です!");
                    Environment.Exit(0);
                }
                else if(ban[2,0] == "w"&&ban[2,1] == "w"&&ban[2,2] == "w"){
                    Console.Write("白の勝利です!");
                    Environment.Exit(0);
                }
                else if(ban[0,0] == "w"&&ban[1,0] == "w"&&ban[2,0] == "w"){
                    Console.Write("白の勝利です!");
                    Environment.Exit(0);
                }
                else if(ban[0,1] == "w"&&ban[1,1] == "w"&&ban[2,1] == "w"){
                    Console.Write("白の勝利です!");
                    Environment.Exit(0);
                }
                else if(ban[0,2] == "w"&&ban[1,2] == "w"&&ban[2,2] == "w"){
                    Console.Write("白の勝利です!");
                    Environment.Exit(0);
                }
                else if(ban[0,0] == "w"&&ban[1,1] == "w"&&ban[2,2] == "w"){
                    Console.Write("白の勝利です!");
                    Environment.Exit(0);
                }
                else if(ban[0,2] == "w"&&ban[1,1] == "w"&&ban[2,0] == "w"){
                    Console.Write("白の勝利です!");
                    Environment.Exit(0);
                }

                w_while1 = 0;
                

            }


            
        }
    }
}
