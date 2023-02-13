using ClientBack.Infrastructure.HTTP;
using System;

namespace MemoHeroDesktopClient.Common
{
    internal class StudyResultHandlerArgs : EventArgs
    {
        internal StudyResult studyResult;

        public StudyResultHandlerArgs(StudyResult studyResult) => this.studyResult = studyResult;
    }
}