// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package java_.lang.reflect;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class AnnotatedElement_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return java_.lang.reflect.AnnotatedElement_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        java_.lang.reflect.AnnotatedElement_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __AnnotatedElement extends system.Object implements java.lang.reflect.AnnotatedElement {
    
    protected __AnnotatedElement(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;")
    public native java.lang.annotation.Annotation getAnnotation(java.lang.Class par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()[Ljava/lang/annotation/Annotation;")
    public native java.lang.annotation.Annotation[] getAnnotations();
    
    @net.sf.jni4net.attributes.ClrMethod("()[Ljava/lang/annotation/Annotation;")
    public native java.lang.annotation.Annotation[] getDeclaredAnnotations();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Class;)Z")
    public native boolean isAnnotationPresent(java.lang.Class par0);
}
//</generated-proxy>