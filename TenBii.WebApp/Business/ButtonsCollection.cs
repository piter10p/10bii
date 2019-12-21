using System.Collections;
using System.Collections.Generic;
using TenBii.WebApp.Business.Buttons;

namespace TenBii.WebApp.Business
{
    public class ButtonsCollection: IEnumerable<IButton>
    {
        private readonly List<IButton> _list = new List<IButton>
        {
            new NButton(),
            new IyrButton(),
            new PvButton(),
            new PmtButton(),
            new FvButton(),
            
            new InputButton(),
            new MuButton(),
            new CstButton(),
            new PrcButton(),
            new MarButton(),
            
            new KButton(),
            new PercentButton(),
            new CfjButton(),
            new SumPlusButton(),
            new ArrowLeftButton(),
            
            new PlusMinusButton(),
            new RclButton(),
            new RightArrowMButton(),
            new RmButton(),
            new MPlusButton(),
            
            new TertiaryButton(),
            new SevenButton(),
            new EightButton(),
            new NineButton(),
            new DivideButton(),
            
            new SecondaryButton(),
            new FourButton(),
            new FiveButton(),
            new SixButton(),
            new MultiplyButton(),
            
            new ClearButton(),
            new OneButton(),
            new TwoButton(),
            new ThreeButton(),
            new MinusButton(),
            
            new HelpButton(),
            new ZeroButton(),
            new DotButton(),
            new EqualsButton(),
            new PlusButton()
        };

        public IEnumerator<IButton> GetEnumerator()
            => _list.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => _list.GetEnumerator();
    }
}