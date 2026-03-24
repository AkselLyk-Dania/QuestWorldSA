using QuestWorldMainWPF.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestWorldMainWPF.Classes
{
    public class Kriger : IBasePClass, IGuard, IMelee
    {
    }

    public class Troldmand : IBasePClass, IGuard, IMagic
    {
    }

    public class Spejder : IBasePClass, IGuard, IRange
    {
    }

    public class Prinsesse : IBasePClass, IMelee, ISpeech
    {
    }

    public class Ridder : IBasePClass, IGuard, IMelee
    {
    }
}
