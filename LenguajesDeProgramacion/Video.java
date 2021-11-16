import java.util.Scanner; //2da parte
import java.io.*;   //4ta parte
import java.net.ServerSocket;   //5ta parte

public class Video{
    public static Scanner sc = new Scanner(System.in);
    public static void main(String[] args) throws IOException{
        //Hello World
        System.out.println("Hello World!");

        //1 - Console ARGS
        Case1(args);
        
        //2 - IO err, out, in
        Case2();

        //3 - venv
        Case3();

        //4 - file IO
        READER();
        
        //5 - network IO
        Case5();
    }
    //1
    public static void Case1(String[] args){
        if (args.length > 0) {
            for (String argx : args) {
                System.out.println(argx);
            }
        }
    }
    //2
    public static void Case2() {
        String temp = sc.nextLine();
        System.out.println(temp+" STDOUT");
        System.err.println(temp+" STDERR");
        //java Video 1>stdout.txt 2>stderr.txt
    }
    //3
    public static void Case3() throws IOException{
        System.out.println(System.getenv("ChocolateyLastPathUpdate"));
        Runtime rt = Runtime.getRuntime();
        Process pr = rt.exec("cmd.exe set ASD=123");
    }
    //4
    public static void READER() throws IOException {
        FileInputStream in = null;
        FileOutputStream out = null;

        try {
            in = new FileInputStream("LENDEPROG.txt");
            out = new FileOutputStream("OUTPUTIO.txt");

            int c;
            while ((c = in.read()) != -1) {
                out.write(c);
            }
        } finally {
            if (in != null) {
                in.close();
            }
            if (out != null) {
                out.close();
            }
        }
    }
    //5
    public static void Case5() throws IOException{
        ServerSocket server = new ServerSocket(54309);
        server.close();
    }
}