# CompilePrincipleHomework
编译原理作业
这个项目是由C#界面和C++exe组成，
exe项目在test文件夹中

打开根目录下sln，确保路径英文，然后右键C#项目生成即可（C++exe会自动生成），项目输出在根目录out文件夹下
测试代码存储在code.txt中，会自动随项目生成复制到out中。

单独exe程序可使用指令 toyPL.exe code.txt 执行。
另可选择-l -p 选项打印lexer 和 syntaxparser 生成的token 和 语法树  
-o 指定打印的输出文件
例：
toyPL.exe code.txt -l -p -o output.txt
 
