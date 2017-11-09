<?xml version="1.0" encoding="utf-8"?>
<applicationModel>
  <name>NameStandardDialog</name>
  <className>ClassStandardDialog</className>
  <objects>
    <object technology="Standard Windows" type="Dialog">
      <name>StandardDialog</name>
      <codeName>StandardDialog</codeName>
      <identification>
        <properties>
          <property name="Text" type="string" isRegExp="true">Firmenassistent|Firmen.*|Lexware.*|Loge.*</property>
          <property name="NativeClass" type="string">#32770</property>
        </properties>
      </identification>
      <children>
        <object technology="Standard Windows" type="Button">
          <name>Button</name>
          <codeName>Button</codeName>
          <identification>
            <properties>
              <property name="Text" type="string">OK</property>
              <property name="NativeClass" type="string">Button</property>
            </properties>
          </identification>
        </object>
      </children>
    </object>
  </objects>
</applicationModel>