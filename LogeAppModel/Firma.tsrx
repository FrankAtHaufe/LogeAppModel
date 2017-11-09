<?xml version="1.0" encoding="utf-8"?>
<applicationModel>
  <name>NameFirmaSeite1</name>
  <className>ClassFirmaSeite1</className>
  <objects>
    <object technology="Standard Windows" type="Dialog">
      <name>Firmenassistent</name>
      <codeName>Firmenassistent</codeName>
      <identification>
        <properties>
          <property name="IsOwnedWindow" type="boolean">true</property>
          <property name="IsChildWindow" type="boolean">false</property>
          <property name="Text" type="string" isRegExp="true">Firmenassistent.*</property>
          <property name="NativeClass" type="string">#32770</property>
        </properties>
      </identification>
      <children>
        <object technology="Standard Windows" type="Button">
          <name>ActionButton</name>
          <codeName>ActionButton</codeName>
          <identification>
            <properties>
              <property name="Text" type="string">Abbrechen</property>
              <property name="NativeClass" type="string">Button</property>
            </properties>
          </identification>
        </object>
        <object technology="Standard Windows" type="EditField">
          <name>Name</name>
          <codeName>NameEditField</codeName>
          <identification>
            <properties>
              <property name="AttachedText" type="string">Firma-Allgemein</property>
              <property name="NativeClass" type="string">Edit</property>
            </properties>
          </identification>
        </object>
        <object technology="Standard Windows" type="EditField">
          <name>Strasse</name>
          <codeName>StrasseEditField</codeName>
          <identification>
            <properties>
              <property name="AttachedText" type="string" />
              <property name="NativeClass" type="string">Edit</property>
            </properties>
          </identification>
        </object>
      </children>
    </object>
  </objects>
</applicationModel>