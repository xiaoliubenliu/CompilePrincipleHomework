# CompilePrincipleIDE
项目为编译原理大作业，由C#界面和C++exe组成，exe项目在interpreterExe文件夹中。

解释型语言解释器，实现了一种简单的类C风格的解释性语言。

解释器支持

- int,long,string,bool的数值运算
- if-else分支
- while循环
- 内建print、read等函数
- 函数递归调用
- 基本数据类型数组存储等

解释器具有良好的报错提示。

#### 构建

项目使用windows下VS构建，打开根目录下sln，确保路径英文，然后右键C#项目生成即可（C++exe会自动生成），项目输出在根目录out文件夹下，测试代码存储在code.txt中，会自动随项目生成自动复制到out中。

#### 说明

可以使用C#界面直接运行。
![uTools_1689051005837](https://github.com/xiaoliubenliu/CompilePrincipleIDE/raw/master/readmePic/uTools_1689059118318.png)

或者使用其他编译器配合控制台执行。

code.txt需要GB2312编码，否则exe执行会出现乱码情况

可以控制台执行代码toyPL.exe code.txt 执行，另可选择：

- -l -p 选项打印lexer 和 syntaxparser 生成的token 和 语法树
- -o 指定打印的输出文件

例：`toyPL.exe code.txt -l -p -o output.txt`

使用exe+vscode执行效果如下

![uTools_1689051005837](https://github.com/xiaoliubenliu/interpreter/raw/master/readmePic/uTools_1689051005837.png)

