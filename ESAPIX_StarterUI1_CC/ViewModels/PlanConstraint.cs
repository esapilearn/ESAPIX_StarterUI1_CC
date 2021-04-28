using ESAPIX.Constraints;
using Prism.Mvvm;

namespace ESAPX_StarterUI.ViewModels
{
    public class PlanConstraint : BindableBase//bindable base helps update UI
    {
        public PlanConstraint(IConstraint con)
        {
            this.Constraint = con;
        }


        private IConstraint _constraint;

        public IConstraint Constraint
        {
            get { return _constraint; }
            set { SetProperty(ref _constraint, value); }//so UI knows to update
        }

        private ConstraintResult _result;

        public ConstraintResult Result
        {
            get { return _result; }
            set { SetProperty(ref _result, value); }
        }
    }
}