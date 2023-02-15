using System;

namespace ncmdumpGUI
{
    public delegate object END_INVOKE(IAsyncResult asynRet);
    public delegate IAsyncResult PROGRESS_DIALOG(string msg);
    public delegate bool IS_FUN();
}
