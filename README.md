This is an example on how to use **System.Threading.Semaphore** object to lock execution between threads.

```
00000003 Entered semaphore
00000004 Semaphore locked
00000005 Semaphore locked
00000008 Semaphore locked
00000007 Semaphore locked
00000006 Semaphore locked
00000009 Semaphore locked
0000000A Semaphore locked
0000000B Semaphore locked
0000000C Semaphore locked
00000003 Released semaphore
00000004 Entered semaphore
00000004 Released semaphore
00000005 Entered semaphore
00000005 Released semaphore
00000006 Entered semaphore
00000006 Released semaphore
00000007 Entered semaphore
00000007 Released semaphore
00000008 Entered semaphore
00000008 Released semaphore
00000009 Entered semaphore
00000009 Released semaphore
0000000A Entered semaphore
0000000B Entered semaphore
0000000A Released semaphore
0000000B Released semaphore
0000000C Entered semaphore
0000000C Released semaphore
```