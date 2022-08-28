# 代码质量

## Tip1 为自己的代码负责
从某个角度来说，成为一个专家需要坦诚面对自己花了多少时间把一件事做好，而不能容许自己把一件事情做糟。

我们以为我们把时间都花在了写代码上，但其实我们把大量的时间花在了读懂已经写好的代码上。据统计，读代码的时间与写代码的时间之比大约是10:1。

因此，写高质量的代码将极大地提高自己的开发效率。

## Tip2 每次只做一件小事

学会将一个巨大的问题分解成一个又一个小问题，并以增量式或迭代式工作。
* 增量式：把大问题分解成相互独立的若干小问题，每次保证解决一个小问题，最后再将其合并。
* 迭代式：将大问题分解成若干步骤，并逐步完成细节。每次只做好本步的工作，并且保证工作的效果。

## Tip3 使用有意义的命名(命名规范)

* 代码中的命名要做到见名知义，避免使用单个字母命名（常用的循环索引变量除外）。
    ``` csharp
    //************反例************
    int h;
    int w;

    //循环索引变量的命名
    for(int i = 0; i < n; i++ ){
        for(int ii = 0; ii < m; ii++ ){

        }
    }

    for(int asdfghj = 0; asdfghj < n; asdfghj++ ){
        for(int iiiiii = 0; iiiiii < m; iiiiii++ ){
            
        }
    }

    //************正例************
    int Height;
    int Width;

    //此处的i、j、k通常认为是循环索引变量
    for(int i = 0; i < n; i++ ){
        a[i] = m;
    }
    ```

* 代码中的命名严禁使用拼音与英文混合的方式，更不允许直接使用中文的方式。
  正确的英文拼写和语法可以让阅读者易于理解，避免歧义。注意，纯拼音命名方式更要避免采用。

    ``` csharp
    //************反例************
    //打折功能
    public void DaZhePromotion(){

    }

    //评分
    public double getPingfenByName(){

    }

    //警报
    public void JignBao(){

    }

    //************正例************
    //打折功能
    public void DiscountPromotion(){

    }
    //评分
    public double GetScoreByName(){

    }
    //警报
    public void Alert(){

    }
    ```

* 杜绝完全不规范的缩写，避免望文不知义。

    ``` csharp
    //************反例************
    //初始化
    public void CSH(){

    }

    //************正例************
    //初始化
    public void Initialize(){

    }
    
    ```

* 统一代码的命名风格，同一个项目应采用同一种命名规范。

    ``` csharp
    //************反例************
    public void Display(){

    }

    public void play(){

    }

    public void _eat(){

    }

    //************正例************
    //初始化
    public void Display(){

    }

    public void Play(){

    }

    public void Eat(){

    }
    
    ```

## Tip4 像写故事一样写代码()

* 函数或类应该具有明确的名称表明其作用；

    ``` csharp
    //************反例************
    public class MyClass{

        public void MyMethod1(){

        }

        public void MyMethod2(){

        }
    }

    //************正例************
    //初始化
    public class SQLHelper{
        
        public void ExecuteNonQuery(){

        }

        public void ExecuteQuery(){

        }

    }
    ```

* 定义函数时应按其逻辑顺序排列；

    ``` csharp
    //************反例************
    public class People{

        public void Run(){

        }

        public void Jump(){

        }

        public void Sleep(){

        }
    }

    //************正例************
    //初始化
    public class People{

        public void Jump(){

        }

        public void Run(){

        }

        public void Sleep(){

        }
    }
    ```

* 尽量减少函数内部 if…else…的层数；
    + 采用抽象方式避免if else的嵌套
    ``` csharp
    //************反例************
    public void Execute(string type){
        if(type == "SQL Server"){
            //Do Something
        }
        else if(type == "Oracle"){
            //Do Something
        }
        else if(type == "MySql"){
            //Do Something
        } 
        else{
            //Do Something
        }
    }

    //************正例************
    public class MSSqlHelper:SQLHelper{
        public override void Execute(){
            //Do Something
        }
    }

    public class OracleHelper:SQLHelper{
        public override void Execute(){
            //Do Something
        }
    }

    public class MySqlHelper:SQLHelper{
        public override void Execute(){
            //Do Something
        }
    }

    public void Execute(SQLHelper helper){
        helper.Execute();
    }
    ```

    + 采用提前Return的方式减少嵌套的层数
    ``` Python
    #************反例************
    def watch_TV(self, finish_homework, like_movie):
        if finish_homework:
            if like_movie:
                watch_movie()
            else:
                watch_others()
    

    #************正例************
    def watch_TV(self, finish_homework, like_movie):
        if not finish_homework:
            return
        if like_music:
            watch_movie()
        else:
            watch_others()
    ```

* 能在一个函数中解决的问题没有必要拆分成几个函数（除非函数太长）。
    ``` Python
    #************反例************
    def get_up(self):
        wash_face()
        brush_teeth()
        
    def wash_face(self):
        pass
    
    def brush_teeth(self):
        pass
    

    #************正例************
    def get_up(self):
        # start washing face
        # ......
        pass

        # start brushing teeth
        # ......
        pass
    ```

## Tip5 不要写没有意义的注释(注释简洁明了)

高质量的代码自己就可以解释自己在做什么。
当你想写注释时，请暂停！想一想除了这种低端方法之外，还有什么方法可以让自己的代码更好理解。

* 我们都听过这样一句话：**“好的代码是自动文档化的”**。我完全同意这种说法，当然有些注释还是有必要的。但是，下面这种注释，明显不能划到“必要”的范畴中：

    ``` csharp
    return true; // returns true 
    ```

这种注释确明显是没有必要的，因为我们很容易理解返回什么。我们能想出的关于为什么要这么注释的唯一原因就是，开发人员在添加到实际代码前，使用注释先制定出了方法，后来却忘记删掉这些注释了。但是如果有代码审查过程的话，就不会出现这样的注释。

## Tip6 手下留情

当你离开时，请让代码比你来时更好

## Tip7 少即是多

单一功能原则：每个类（函数）都应该有一个单一的功能，并且该功能应该由这个类（函数）完全封装起来。

## Tip8 避免无意义的复杂化

能读懂的、适当抽象凝练的代码体现了编程者的智慧
读不懂的、故弄玄虚的复杂代码体现了编程者的愚蠢

## Tip9 代码风格保持一致


## Tip10 勤能补拙
* 能吃苦
* 能坚持
* 多思考
* 勤练习
