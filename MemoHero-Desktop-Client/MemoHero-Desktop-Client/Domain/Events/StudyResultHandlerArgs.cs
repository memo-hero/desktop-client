using ClientBack.Domain.Study;
using System;

namespace MemoHeroDesktopClient.Domain.Events
{
    internal class StudyResultHandlerArgs : EventArgs
    {
        internal StudyResult studyResult;

        public StudyResultHandlerArgs(StudyResult studyResult) => this.studyResult = studyResult;
    }
}