#gcc -I"$JAVA_HOME/include" -I"$JAVA_HOME/include/linux" -shared -fPIC  HelloJNI.c

#source ~/.profile
echo $JAVA_HOME

#ls $JAVA_HOME/include
#ls $JAVA_HOME/include/linux

gcc -fpic -c -I"$JAVA_HOME/include" -I"$JAVA_HOME/include/linux"   HelloJNI.c -o HelloJNI.o
gcc -shared -o HelloJNI.so HelloJNI.o

javac -h . HelloJNI.java
