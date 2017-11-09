<?xml version="1.0" encoding="utf-8"?>
<applicationModel>
  <name>NameHauptmenue</name>
  <className>ClassHauptmenue</className>
  <objects>
    <object technology="Standard Windows" type="Window">
      <name>Lexware professional</name>
      <codeName>LexwareProfessionalWindow</codeName>
      <identification>
        <properties>
          <property name="IsOwnedWindow" type="boolean">false</property>
          <property name="IsChildWindow" type="boolean">false</property>
          <property name="WindowClassRegExp" type="string">Afx:</property>
          <property name="WindowTitleRegExp" type="string" isRegExp="true">Lexware.*</property>
        </properties>
      </identification>
      <children>
        <object technology="Standard Windows" type="UiObject">
          <name>Menueleiste</name>
          <codeName>MenLeisteUiObject</codeName>
          <identification>
            <properties>
              <property name="WindowClassRegExp" type="string">XTPToolBar</property>
              <property name="WindowTitleRegExp" type="string">Menüleiste</property>
            </properties>
          </identification>
        </object>
      </children>
    </object>
  </objects>
</applicationModel>