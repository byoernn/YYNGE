# YYNGE
A project to learn how to write a compiler targeting WASM from m***y*** ver***y*** ow***n*** programmin***g*** languag***e*** :)

## Lizenz
https://choosealicense.com/licenses/eupl-1.2/

## Module
A YYNGE Module is represented by a single [filename].yym file.
This file will be compiled into a single WebAssemblyModule (wasm file).

## WAPP
This project contains a simple .net core PWA (called WAPP - Web Assembly Application) calling an api 
which uses the DotNetCompiler for YYNGE to compile and deliver the wasm.  
The API´s also represent the different TestCases.

## YYNGE - Language to better write webassembly  
Idea for implementation:

```
    import WASI.Console;
    import WAPP;
    int c = 3;
    //adds two numbers to 3
    //returns the result as integer
    export func<int> add (int a, int b) =>
    {
        return a+b+c;
    }
```
Code just uses simple //comments.  
WASI or WAPP could be interfaces that define imported fuctions.