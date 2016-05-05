The application receives N as input parameter (e.g PrimeTestApp.exe 10 )

As optimization the application can be extended when the input (N) is over a certain number to do a Parallel.ForEach and go through intervals since GeneratePrimeArray receives a minimum and a maximum. The result of all the intervals can then be joined together after all threads finish processing.

Sorry the commits are not there. I realized later on that I had to do commits to github as I go along.