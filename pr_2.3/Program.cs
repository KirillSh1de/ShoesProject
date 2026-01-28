namespace pr_2._3.Models
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            bool exitProgram = false;

            while (!exitProgram) {
                using (var formLogin = new FormLog()) {
                    if (formLogin.ShowDialog() == DialogResult.OK) {
                        using (var formProducts = new FormProducts(
                            formLogin.CurrentUser,
                            formLogin.IsGuest)) {
                            if(formProducts.ShowDialog() == DialogResult.Cancel) {
                                continue;
                            } else {
                                exitProgram = true;
                            }
                        }
                    } else {
                        exitProgram = true;
                    }
                }
            }
            
        }
    }
}