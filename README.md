# CovarianceAndContravarianceDelegateExample
<h1>COVARIANCE</h1>
</br>
</br>public class BaseClass{
	</br>//class code
</br>}
</br>public class DerivedClass:BaseClass{
	</br>//class code
</br>}
</br>delegate BaseClass MyDelegate();
</br>//+return type and parameter types of the method referenced by a delegate object must match the return type and parameter types defined in the relevant delegates definition 
</br>//+ the return type and parameter types of the relevant method definition dont have to match with the relevant return type and parameter types delegate definition exactly

</br>public static DerivedClassMyMethod(){
	</br>//method code
</br>}

</br>static void Main(){
	</br>MyDelegate myDelegate = MyMethod;
</br>}
<h1>CONTRAVARIANCE</h1>
</br>//permits a method that has parameter types that are less derived than those in the relevance delegates type
</br>//Even though the parameter type ò the 'MyMethod' method í les derived than the parameter type ò the 'MyDelegat1' delegate and the 'MyDelegate2' delegate an object of type MyDelegate1 and MyDelegate2 can reference the 'MyMethod' method 
</br>public class BaseClass{
	</br>//class code
</br>}
</br>public clas DerivedClassBaseClass{
	</br>//class code
</br>}
</br>public class DerivedClass2BaseClass{
	</br>//class code
</br>}
</br>delegate void MyDelegate1(DeriveredClass1 derivedClass1);
</br>delegate void MyDelegate2(DerivedClass2 derivedClass2);
</br>public static void MyMethod(BaseClass obj){
	</br>//method code
</br>}
</br>static void Main(){
	</br>MyDelegate1 myDelegate1 = MyMethod;
	</br>MyDelegate2 myDelegate2 = MyMethod;
</br>}
