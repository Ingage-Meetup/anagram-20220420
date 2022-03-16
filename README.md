# Word Wrap

## Description

Given a string of text without any line breaks, insert appropriate line breaks so that the text will fit in a column N characters wide.

Write the following function:

        wrap(String s, int w)

## The Challenge

This exercise is taken from Robert Martin's Clean Craftsmanship, pp. 96-103. Following are the exact test cases Uncle Bob uses in the book to derive an implementation of word wrap.

See if you can use these same test cases to create your solution. The cases are listed in the order that Martin presents them in the book.

## Test Cases

        assert.equal(wrap("", 1),"" )
        assert.equal(wrap("x", 1), "x")
        assert.equal(wrap("xx", 1), "x\nx")
        assert.equal(wrap("xx", 2), "xx")
        assert.equal(wrap("xxx", 1), "x\nx\nx")
        assert.equal(wrap("xxx", 2), "xx\nx")
        assert.equal(wrap("xxx", 2), "xx\nx")
        assert.equal(wrap("x x", 1), "x\nx")
        assert.equal(wrap("x x", 2), "x\nx")
        assert.equal(wrap("x x", 3), "x x")
        assert.equal(wrap("x x x", 1), "x\nx\nx")
        assert.equal(wrap("x x x", 2), "x\nx\nx")
        assert.equal(wrap("x x x", 3), "x x\nx")
        assert.equal(wrap("x x x", 4), "x x\nx")
        assert.equal(wrap("x x x", 5), "x x x")
        assert.equal(wrap("xx xx", 1), "x\nx\nx\nx")
        assert.equal(wrap("xx xx", 2), "xx\nxx")
        assert.equal(wrap("xx xx", 3), "xx\nxx") 
        assert.equal(wrap("xx xx", 4), "xx\nxx")
        assert.equal(wrap("xx xx", 5), "xx xx")
        assert.equal(wrap("xx xx xx", 1), "x\nx\nx\nx\nx\nx")
        assert.equal(wrap("xx xx xx", 2), "xx\nxx\nxx")
        assert.equal(wrap("xx xx xx", 3), "xx\nxx\nxx")
        assert.equal(wrap("xx xx xx", 4), "xx\nxx\nxx")
        assert.equal(wrap("xx xx xx", 5), "xx xx\nxx")
        assert.equal(wrap("xx xx xx", 6), "xx xx\nxx")
        assert.equal(wrap("xx xx xx", 7), "xx xx\nxx")
        assert.equal(wrap("xx xx xx", 8), "xx xx xx")


## About this template

See solutions in different languages in the "Templates" directory. Once you decide which language you'd like to use,
simply open that directory in your favorite IDE, and you should be able to run the included unit tests "out of the box".

The recommended IDEs are as follows, but feel free to use whatever IDE you are comfortable with.

-   [C#](Templates/C#) - [Microsoft Visual Studio](https://visualstudio.microsoft.com/vs/community/)
-   [Java](Templates/Java) - [IntelliJ Idea](https://www.jetbrains.com/idea/download) (Community Edition is fine)
-   [JavaScript](Templates/JavaScript) - [Microsoft Visual Studio Code](https://code.visualstudio.com/)
-   [Kotlin](Templates/Kotlin) - [IntelliJ Idea](https://www.jetbrains.com/idea/download) (Community Edition is fine)
