import { SignInForm } from '../../views/SignInForm/SignInForm';
import signInImg from '../../assets/images/signin.png';
import './SignInPage.scss';
import { PageHeader } from '../../components/PageHeader';


export const SignInPage: React.FC<{}> = ({ }) => {
  return (
    <div className='signin-page'>
      <PageHeader headerText='Авторизація'/>
      <div className='signin-page__image-container'>
        <img src={signInImg} alt='' />
      </div>
      <SignInForm />
    </div>
  );
};