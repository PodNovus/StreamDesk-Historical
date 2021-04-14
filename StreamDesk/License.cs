﻿#region License Header
// KtecK Lab's StreamDesk
// Code (C) NasuTek-Alliant Enterprises, 2010; David Kellaway, 2008.
// StreamDesk and the StreamDesk logo are copyright (C) KtecK 2007-2010.
// Licensed under the NasuTek Restrictive Development License Version 1.00
#endregion

#region Using Directives
using System;
using System.Windows.Forms;

#endregion

namespace StreamDesk {
    public partial class License : Form {
        public License () {
            InitializeComponent ();
            richTextBox1.Rtf =
                @"{\rtf1\adeflang1025\ansi\ansicpg1252\uc1\adeff31507\deff0\stshfdbch31505\stshfloch31506\stshfhich31506\stshfbi31507\deflang1033\deflangfe1033\themelang1033\themelangfe0\themelangcs0{\fonttbl{\f0\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\f1\fbidi \fswiss\fcharset0\fprq2{\*\panose 020b0604020202020204}Arial;}
{\f3\fbidi \froman\fcharset2\fprq2{\*\panose 05050102010706020507}Symbol;}{\f34\fbidi \froman\fcharset1\fprq2{\*\panose 02040503050406030204}Cambria Math;}{\flomajor\f31500\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}
{\fdbmajor\f31501\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\fhimajor\f31502\fbidi \froman\fcharset0\fprq2{\*\panose 02040503050406030204}Cambria;}
{\fbimajor\f31503\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\flominor\f31504\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}
{\fdbminor\f31505\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\fhiminor\f31506\fbidi \fswiss\fcharset0\fprq2{\*\panose 020f0502020204030204}Calibri;}
{\fbiminor\f31507\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\f39\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\f40\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}
{\f42\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\f43\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\f44\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\f45\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}
{\f46\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\f47\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\f49\fbidi \fswiss\fcharset238\fprq2 Arial CE;}{\f50\fbidi \fswiss\fcharset204\fprq2 Arial Cyr;}
{\f52\fbidi \fswiss\fcharset161\fprq2 Arial Greek;}{\f53\fbidi \fswiss\fcharset162\fprq2 Arial Tur;}{\f54\fbidi \fswiss\fcharset177\fprq2 Arial (Hebrew);}{\f55\fbidi \fswiss\fcharset178\fprq2 Arial (Arabic);}
{\f56\fbidi \fswiss\fcharset186\fprq2 Arial Baltic;}{\f57\fbidi \fswiss\fcharset163\fprq2 Arial (Vietnamese);}{\flomajor\f31508\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\flomajor\f31509\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}
{\flomajor\f31511\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\flomajor\f31512\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\flomajor\f31513\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}
{\flomajor\f31514\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}{\flomajor\f31515\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\flomajor\f31516\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}
{\fdbmajor\f31518\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\fdbmajor\f31519\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\fdbmajor\f31521\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}
{\fdbmajor\f31522\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\fdbmajor\f31523\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\fdbmajor\f31524\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}
{\fdbmajor\f31525\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\fdbmajor\f31526\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\fhimajor\f31528\fbidi \froman\fcharset238\fprq2 Cambria CE;}
{\fhimajor\f31529\fbidi \froman\fcharset204\fprq2 Cambria Cyr;}{\fhimajor\f31531\fbidi \froman\fcharset161\fprq2 Cambria Greek;}{\fhimajor\f31532\fbidi \froman\fcharset162\fprq2 Cambria Tur;}
{\fhimajor\f31535\fbidi \froman\fcharset186\fprq2 Cambria Baltic;}{\fbimajor\f31538\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\fbimajor\f31539\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}
{\fbimajor\f31541\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\fbimajor\f31542\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\fbimajor\f31543\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}
{\fbimajor\f31544\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}{\fbimajor\f31545\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\fbimajor\f31546\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}
{\flominor\f31548\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\flominor\f31549\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\flominor\f31551\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}
{\flominor\f31552\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\flominor\f31553\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\flominor\f31554\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}
{\flominor\f31555\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\flominor\f31556\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\fdbminor\f31558\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}
{\fdbminor\f31559\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\fdbminor\f31561\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\fdbminor\f31562\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}
{\fdbminor\f31563\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\fdbminor\f31564\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}{\fdbminor\f31565\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}
{\fdbminor\f31566\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\fhiminor\f31568\fbidi \fswiss\fcharset238\fprq2 Calibri CE;}{\fhiminor\f31569\fbidi \fswiss\fcharset204\fprq2 Calibri Cyr;}
{\fhiminor\f31571\fbidi \fswiss\fcharset161\fprq2 Calibri Greek;}{\fhiminor\f31572\fbidi \fswiss\fcharset162\fprq2 Calibri Tur;}{\fhiminor\f31575\fbidi \fswiss\fcharset186\fprq2 Calibri Baltic;}
{\fbiminor\f31578\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\fbiminor\f31579\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\fbiminor\f31581\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}
{\fbiminor\f31582\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\fbiminor\f31583\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\fbiminor\f31584\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}
{\fbiminor\f31585\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\fbiminor\f31586\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}}{\colortbl;\red0\green0\blue0;\red0\green0\blue255;\red0\green255\blue255;\red0\green255\blue0;
\red255\green0\blue255;\red255\green0\blue0;\red255\green255\blue0;\red255\green255\blue255;\red0\green0\blue128;\red0\green128\blue128;\red0\green128\blue0;\red128\green0\blue128;\red128\green0\blue0;\red128\green128\blue0;\red128\green128\blue128;
\red192\green192\blue192;}{\*\defchp \fs22\loch\af31506\hich\af31506\dbch\af31505 }{\*\defpap \ql \li0\ri0\sa200\sl276\slmult1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0 }\noqfpromote {\stylesheet{
\ql \li0\ri0\sa200\sl276\slmult1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0 \rtlch\fcs1 \af31507\afs22\alang1025 \ltrch\fcs0 \fs22\lang1033\langfe1033\loch\f31506\hich\af31506\dbch\af31505\cgrid\langnp1033\langfenp1033 
\snext0 \sqformat \spriority0 Normal;}{\*\cs10 \additive \ssemihidden \sunhideused \spriority1 Default Paragraph Font;}{\*
\ts11\tsrowd\trftsWidthB3\trpaddl108\trpaddr108\trpaddfl3\trpaddft3\trpaddfb3\trpaddfr3\trcbpat1\trcfpat1\tblind0\tblindtype3\tscellwidthfts0\tsvertalt\tsbrdrt\tsbrdrl\tsbrdrb\tsbrdrr\tsbrdrdgl\tsbrdrdgr\tsbrdrh\tsbrdrv \ql \li0\ri0\sa200\sl276\slmult1
\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0 \rtlch\fcs1 \af31507\afs22\alang1025 \ltrch\fcs0 \fs22\lang1033\langfe1033\loch\f31506\hich\af31506\dbch\af31505\cgrid\langnp1033\langfenp1033 
\snext11 \ssemihidden \sunhideused \sqformat Normal Table;}}{\*\listtable{\list\listtemplateid-1513591644\listsimple{\listlevel\levelnfc23\levelnfcn23\leveljc0\leveljcn0\levelfollow0\levelstartat0\levelspace0\levelindent0{\leveltext\'01*;}{\levelnumbers;}
\hres0\chhres0 }{\listname ;}\listid-2}}{\*\listoverridetable{\listoverride\listid-2\listoverridecount1{\lfolevel\listoverrideformat{\listlevel\levelnfc23\levelnfcn23\leveljc0\leveljcn0\levelfollow0\levelstartat0\levelold\levelspace0\levelindent0
{\leveltext\'01\u-3913 ?;}{\levelnumbers;}\f3\fbias0 }}\ls1}}{\*\rsidtbl \rsid13122715\rsid13829082}{\mmathPr\mmathFont34\mbrkBin0\mbrkBinSub0\msmallFrac0\mdispDef1\mlMargin0\mrMargin0\mdefJc1\mwrapIndent1440\mintLim0\mnaryLim1}{\info{\operator kevin}
{\creatim\yr2009\mo12\dy4\hr2\min12}{\revtim\yr2009\mo12\dy4\hr2\min40}{\version2}{\edmins5}{\nofpages2}{\nofwords562}{\nofchars2888}{\nofcharsws3444}{\vern32771}}{\*\xmlnstbl {\xmlns1 http://schemas.microsoft.com/office/word/2003/wordml}}
\paperw12240\paperh15840\margl1440\margr1440\margt1440\margb1440\gutter0\ltrsect 
\widowctrl\ftnbj\aenddoc\trackmoves1\trackformatting1\donotembedsysfont0\relyonvml0\donotembedlingdata1\grfdocevents0\validatexml0\showplaceholdtext0\ignoremixedcontent0\saveinvalidxml0\showxmlerrors0\horzdoc\dghspace120\dgvspace120\dghorigin1701
\dgvorigin1984\dghshow0\dgvshow3\jcompress\viewkind1\viewscale100\rsidroot13122715 \fet0{\*\wgrffmtfilter 2450}\ilfomacatclnup0\ltrpar \sectd \ltrsect\linex0\sectdefaultcl\sftnbj {\*\pnseclvl1\pnucrm\pnstart1\pnindent720\pnhang {\pntxta .}}{\*\pnseclvl2
\pnucltr\pnstart1\pnindent720\pnhang {\pntxta .}}{\*\pnseclvl3\pndec\pnstart1\pnindent720\pnhang {\pntxta .}}{\*\pnseclvl4\pnlcltr\pnstart1\pnindent720\pnhang {\pntxta )}}{\*\pnseclvl5\pndec\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl6
\pnlcltr\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl7\pnlcrm\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl8\pnlcltr\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl9\pnlcrm\pnstart1\pnindent720\pnhang 
{\pntxtb (}{\pntxta )}}\pard\plain \ltrpar\qc \li0\ri0\nowidctlpar\wrapdefault\faauto\rin0\lin0\itap0 \rtlch\fcs1 \af31507\afs22\alang1025 \ltrch\fcs0 \fs22\lang1033\langfe1033\loch\af31506\hich\af31506\dbch\af31505\cgrid\langnp1033\langfenp1033 {
\rtlch\fcs1 \ab\af1\afs20 \ltrch\fcs0 \b\f1\fs20\insrsid13829082 \hich\af1\dbch\af31505\loch\f1 NasuTek Restrictive Development License Version 1.00}{\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13829082 
\par }\pard \ltrpar\ql \li0\ri0\nowidctlpar\wrapdefault\faauto\rin0\lin0\itap0 {\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13829082 
\par }{\rtlch\fcs1 \ab\af1\afs20 \ltrch\fcs0 \b\f1\fs20\insrsid13829082 \hich\af1\dbch\af31505\loch\f1 1. Overview
\par }{\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13829082 
\par \hich\af1\dbch\af31505\loch\f1 The NT-RDL is a license that allows access to the source code but can only be edited and used for the development of the original app developers. Under this license you cannot make }{\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 
\f1\fs20\insrsid13122715 \hich\af1\dbch\af31505\loch\f1 derivatives}{\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13829082 \hich\af1\dbch\af31505\loch\f1  for commercial or non-commercial use. This allows the original \hich\af1\dbch\af31505\loch\f1 
development team to allow communities to edit and fix bugs and help improve the project, but disallows the users to make }{\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13122715 \hich\af1\dbch\af31505\loch\f1 their}{\rtlch\fcs1 \af1\afs20 
\ltrch\fcs0 \f1\fs20\insrsid13829082 \hich\af1\dbch\af31505\loch\f1  own versions and distributing them. This license does not forbid modding for personal use but does disallow any redistribution of\hich\af1\dbch\af31505\loch\f1 
 those versions unless to the original development team.
\par 
\par }{\rtlch\fcs1 \ab\af1\afs20 \ltrch\fcs0 \b\f1\fs20\insrsid13829082 \hich\af1\dbch\af31505\loch\f1 2. Definitions}{\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13829082 
\par 
\par {\pntext\pard\plain\ltrpar \rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f3\fs20 \loch\af3\dbch\af31505\hich\f3 \'b7\tab}}\pard \ltrpar\ql \fi-720\li720\ri0\nowidctlpar\wrapdefault{\*\pn \pnlvlblt\ilvl0\ls1\pnrnot0\pnf3 {\pntxtb \'b7}}
\faauto\ls1\rin0\lin720\itap0\pararsid13122715 {\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13829082 \hich\af1\dbch\af31505\loch\f1 The terms ""reproduce,"" ""reproduction,"" and ""distribution"" have the same meaning here as under U.S. copyright law.

\par {\pntext\pard\plain\ltrpar \rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f3\fs20 \loch\af3\dbch\af31505\hich\f3 \'b7\tab}\hich\af1\dbch\af31505\loch\f1 ""Original development team"" and ""The Licensor"" means the compan\hich\af1\dbch\af31505\loch\f1 
y or development team that created the original software
\par {\pntext\pard\plain\ltrpar \rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f3\fs20 \loch\af3\dbch\af31505\hich\f3 \'b7\tab}\hich\af1\dbch\af31505\loch\f1 ""You"" means the licensee of the software.
\par {\pntext\pard\plain\ltrpar \rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f3\fs20 \loch\af3\dbch\af31505\hich\f3 \'b7\tab}\hich\af1\dbch\af31505\loch\f1 ""Your company"" means the company you worked for when you downloaded the software.
\par {\pntext\pard\plain\ltrpar \rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f3\fs20 \loch\af3\dbch\af31505\hich\f3 \'b7\tab}\hich\af1\dbch\af31505\loch\f1 ""Reference use"" means use of the software within your company as a re\hich\af1\dbch\af31505\loch\f1 
ference, in read only form, for the sole purposes of debugging your products, maintaining your products, or enhancing the interoperability of your products with the software, and specifically excludes the right to distribute the software outside of your c
\hich\af1\dbch\af31505\loch\f1 o\hich\af1\dbch\af31505\loch\f1 mpany.
\par {\pntext\pard\plain\ltrpar \rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f3\fs20 \loch\af3\dbch\af31505\hich\f3 \'b7\tab}\hich\af1\dbch\af31505\loch\f1 
""Licensed patents"" means any Licensor patent claims which read directly on the software as distributed by the Licensor under this license.
\par }\pard \ltrpar\ql \li0\ri0\nowidctlpar\wrapdefault\faauto\rin0\lin0\itap0 {\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13829082 
\par }{\rtlch\fcs1 \ab\af1\afs20 \ltrch\fcs0 \b\f1\fs20\insrsid13829082 \hich\af1\dbch\af31505\loch\f1 3. Terms
\par }{\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13829082 
\par {\pntext\pard\plain\ltrpar \rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f3\fs20 \loch\af3\dbch\af31505\hich\f3 \'b7\tab}}\pard \ltrpar\ql \fi-720\li720\ri0\nowidctlpar\wrapdefault{\*\pn \pnlvlblt\ilvl0\ls1\pnrnot0\pnf3 {\pntxtb \'b7}}
\faauto\ls1\rin0\lin720\itap0\pararsid13122715 {\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13829082 \hich\af1\dbch\af31505\loch\f1 You are not allowed to redistribute any source or binary versions of the modified app unless }{\rtlch\fcs1 
\af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13122715 \hich\af1\dbch\af31505\loch\f1 it\hich\f1 \rquote \loch\f1 s}{\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13829082 \hich\af1\dbch\af31505\loch\f1  to the original development team
\par {\pntext\pard\plain\ltrpar \rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f3\fs20 \loch\af3\dbch\af31505\hich\f3 \'b7\tab}\hich\af1\dbch\af31505\loch\f1 Source code is provided to only help the original development team to improve the application or if }{
\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13122715 \hich\af1\dbch\af31505\loch\f1 it\hich\f1 \rquote \loch\f1 s}{\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13829082 \hich\af1\dbch\af31505\loch\f1 
 a Library the same applies but gives the licensee reference use to debug }{\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13122715 \hich\af1\dbch\af31505\loch\f1 their}{\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13829082 
\hich\af1\dbch\af31505\loch\f1  applications }{\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13122715 \hich\af1\dbch\af31505\loch\f1 that\hich\f1 \rquote \loch\f1 s}{\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13829082 
\hich\af1\dbch\af31505\loch\f1  using the librar\hich\af1\dbch\af31505\loch\f1 y
\par {\pntext\pard\plain\ltrpar \rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f3\fs20 \loch\af3\dbch\af31505\hich\f3 \'b7\tab}\hich\af1\dbch\af31505\loch\f1 No Trademark License- This license does not grant you any rights to use the Licensor\hich\f1 \rquote \loch\f1 
s name, logo,\hich\af1\dbch\af31505\loch\f1 
 or trademarks. If you begin patent litigation against the Licensor over patents that you think may apply to the software (including a cross-claim or counterclaim in a lawsuit), your license to the software ends automatically.
\par {\pntext\pard\plain\ltrpar \rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f3\fs20 \loch\af3\dbch\af31505\hich\f3 \'b7\tab}\hich\af1\dbch\af31505\loch\f1 If you don't agree to this }{\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13122715 
\hich\af1\dbch\af31505\loch\f1 lice\hich\af1\dbch\af31505\loch\f1 nse}{\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13829082 \hich\af1\dbch\af31505\loch\f1  you are obligated to delete the source and any files related to it
\par {\pntext\pard\plain\ltrpar \rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f3\fs20 \loch\af3\dbch\af31505\hich\f3 \'b7\tab}\hich\af1\dbch\af31505\loch\f1 
The software is licensed ""as-is."" You bear the risk of using it. The Licensor gives no express warranties, guarantees or conditions. You may have additional consumer rights under \hich\af1\dbch\af31505\loch\f1 
your local laws which this license cannot change. To the extent permitted under your local laws, the Licensor excludes the implied warranties of merchantability, fitness for a particular purpose and non-infringement.
\par }\pard \ltrpar\ql \li0\ri0\nowidctlpar\wrapdefault\faauto\rin0\lin0\itap0 {\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13829082 
\par }{\rtlch\fcs1 \ab\af1\afs20 \ltrch\fcs0 \b\f1\fs20\insrsid13829082 \hich\af1\dbch\af31505\loch\f1 4. Grant of Rights}{\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13829082 
\par 
\par {\pntext\pard\plain\ltrpar \rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f3\fs20 \loch\af3\dbch\af31505\hich\f3 \'b7\tab}}\pard \ltrpar\ql \fi-720\li720\ri0\nowidctlpar\wrapdefault{\*\pn \pnlvlblt\ilvl0\ls1\pnrnot0\pnf3 {\pntxtb \'b7}}
\faauto\ls1\rin0\lin720\itap0\pararsid13122715 {\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13829082 \hich\af1\dbch\af31505\loch\f1 Copyright Grant\hich\af1\dbch\af31505\loch\f1 
- Subject to the terms of this license, the Licensor grants you a non-transferable, non-exclusive, worldwide, royalty-free copyright license to reproduce the software for reference use.
\par {\pntext\pard\plain\ltrpar \rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f3\fs20 \loch\af3\dbch\af31505\hich\f3 \'b7\tab}\hich\af1\dbch\af31505\loch\f1 Patent Grant- Subject to the terms of this license, the Licensor gra\hich\af1\dbch\af31505\loch\f1 
nts you a non-transferable, non-exclusive, worldwide, royalty-free patent license under licensed patents for reference use.
\par }\pard \ltrpar\ql \li0\ri0\nowidctlpar\wrapdefault\faauto\rin0\lin0\itap0 {\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13829082 
\par }{\rtlch\fcs1 \ab\af1\afs20 \ltrch\fcs0 \b\f1\fs20\insrsid13829082 \hich\af1\dbch\af31505\loch\f1 5. Waiving of license
\par }{\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13829082 
\par \hich\af1\dbch\af31505\loch\f1 You can get a explicit waive to allow distribution of your version of the app but you must pay a fee and if \hich\af1\dbch\af31505\loch\f1 
you are allowing editing of the source code outside of your development team it must be the NT-RDL. It }{\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 \f1\fs20\insrsid13122715 \hich\af1\dbch\af31505\loch\f1 cannot}{\rtlch\fcs1 \af1\afs20 \ltrch\fcs0 
\f1\fs20\insrsid13829082 \hich\af1\dbch\af31505\loch\f1  be licensed under a open source license like GPL or BSD. If you sell this app you must pay 25% royalties of the profit made.
\par }{\*\themedata 504b030414000600080000002100828abc13fa0000001c020000130000005b436f6e74656e745f54797065735d2e786d6cac91cb6ac3301045f785fe83d0b6d8
72ba28a5d8cea249777d2cd20f18e4b12d6a8f843409c9df77ecb850ba082d74231062ce997b55ae8fe3a00e1893f354e9555e6885647de3a8abf4fbee29bbd7
2a3150038327acf409935ed7d757e5ee14302999a654e99e393c18936c8f23a4dc072479697d1c81e51a3b13c07e4087e6b628ee8cf5c4489cf1c4d075f92a0b
44d7a07a83c82f308ac7b0a0f0fbf90c2480980b58abc733615aa2d210c2e02cb04430076a7ee833dfb6ce62e3ed7e14693e8317d8cd0433bf5c60f53fea2fe7
065bd80facb647e9e25c7fc421fd2ddb526b2e9373fed4bb902e182e97b7b461e6bfad3f010000ffff0300504b030414000600080000002100a5d6a7e7c00000
00360100000b0000005f72656c732f2e72656c73848fcf6ac3300c87ef85bd83d17d51d2c31825762fa590432fa37d00e1287f68221bdb1bebdb4fc7060abb08
84a4eff7a93dfeae8bf9e194e720169aaa06c3e2433fcb68e1763dbf7f82c985a4a725085b787086a37bdbb55fbc50d1a33ccd311ba548b63095120f88d94fbc
52ae4264d1c910d24a45db3462247fa791715fd71f989e19e0364cd3f51652d73760ae8fa8c9ffb3c330cc9e4fc17faf2ce545046e37944c69e462a1a82fe353
bd90a865aad41ed0b5b8f9d6fd010000ffff0300504b0304140006000800000021006b799616830000008a0000001c0000007468656d652f7468656d652f7468
656d654d616e616765722e786d6c0ccc4d0ac3201040e17da17790d93763bb284562b2cbaebbf600439c1a41c7a0d29fdbd7e5e38337cedf14d59b4b0d592c9c
070d8a65cd2e88b7f07c2ca71ba8da481cc52c6ce1c715e6e97818c9b48d13df49c873517d23d59085adb5dd20d6b52bd521ef2cdd5eb9246a3d8b4757e8d3f7
29e245eb2b260a0238fd010000ffff0300504b03041400060008000000210096b5ade296060000501b0000160000007468656d652f7468656d652f7468656d65
312e786d6cec594f6fdb3614bf0fd87720746f6327761a07758ad8b19b2d4d1bc46e871e698996d850a240d2497d1bdae38001c3ba618715d86d87615b8116d8
a5fb34d93a6c1dd0afb0475292c5585e9236d88aad3e2412f9e3fbff1e1fa9abd7eec70c1d1221294fda5efd72cd4324f1794093b0eddd1ef62fad79482a9c04
98f184b4bd2991deb58df7dfbb8ad755446282607d22d771db8b944ad79796a40fc3585ee62949606ecc458c15bc8a702910f808e8c66c69b9565b5d8a314d3c
94e018c8de1a8fa94fd05093f43672e23d06af89927ac06762a049136785c10607758d9053d965021d62d6f6804fc08f86e4bef210c352c144dbab999fb7b471
7509af678b985ab0b6b4ae6f7ed9ba6c4170b06c788a705430adf71bad2b5b057d03606a1ed7ebf5babd7a41cf00b0ef83a6569632cd467faddec9699640f671
9e76b7d6ac355c7c89feca9cccad4ea7d36c65b258a206641f1b73f8b5da6a6373d9c11b90c537e7f08dce66b7bbeae00dc8e257e7f0fd2badd5868b37a088d1
e4600ead1ddaef67d40bc898b3ed4af81ac0d76a197c86826828a24bb318f3442d8ab518dfe3a20f000d6458d104a9694ac6d88728eee2782428d60cf03ac1a5
193be4cbb921cd0b495fd054b5bd0f530c1931a3f7eaf9f7af9e3f45c70f9e1d3ff8e9f8e1c3e3073f5a42ceaa6d9c84e5552fbffdeccfc71fa33f9e7ef3f2d1
17d57859c6fffac327bffcfc793510d26726ce8b2f9ffcf6ecc98baf3efdfdbb4715f04d814765f890c644a29be408edf3181433567125272371be15c308d3f2
8acd249438c19a4b05fd9e8a1cf4cd296699771c393ac4b5e01d01e5a30a787d72cf1178108989a2159c77a2d801ee72ce3a5c545a6147f32a99793849c26ae6
6252c6ed637c58c5bb8b13c7bfbd490a75330f4b47f16e441c31f7184e140e494214d273fc80900aedee52ead87597fa824b3e56e82e451d4c2b4d32a423279a
668bb6690c7e9956e90cfe766cb37b077538abd27a8b1cba48c80acc2a841f12e698f13a9e281c57911ce298950d7e03aba84ac8c154f8655c4f2af074481847
bd804859b5e696007d4b4edfc150b12addbecba6b18b148a1e54d1bc81392f23b7f84137c2715a851dd0242a633f900710a218ed715505dfe56e86e877f0034e
16bafb0e258ebb4faf06b769e888340b103d3311da9750aa9d0a1cd3e4efca31a3508f6d0c5c5c398602f8e2ebc71591f5b616e24dd893aa3261fb44f95d843b
5974bb5c04f4edafb95b7892ec1108f3f98de75dc97d5772bdff7cc95d94cf672db4b3da0a6557f70db629362d72bcb0431e53c6066acac80d699a6409fb44d0
8741bdce9c0e4971624a2378cceaba830b05366b90e0ea23aaa241845368b0eb9e2612ca8c742851ca251ceccc70256d8d87265dd96361531f186c3d9058edf2
c00eafe8e1fc5c509031bb4d680e9f39a3154de0accc56ae644441edd76156d7429d995bdd88664a9dc3ad50197c38af1a0c16d684060441db02565e85f3b966
0d0713cc48a0ed6ef7dedc2dc60b17e92219e180643ed27acffba86e9c94c78ab90980d8a9f0913ee49d62b512b79626fb06dccee2a432bbc60276b9f7dec44b
7904cfbca4f3f6443ab2a49c9c2c41476dafd55c6e7ac8c769db1bc399161ee314bc2e75cf8759081743be1236ec4f4d6693e5336fb672c5dc24a8c33585b5fb
9cc24e1d4885545b58463634cc5416022cd19cacfccb4d30eb45296023fd35a458598360f8d7a4003bbaae25e331f155d9d9a5116d3bfb9a95523e51440ca2e0
088dd844ec6370bf0e55d027a012ae264c45d02f708fa6ad6da6dce29c255df9f6cae0ec38666984b372ab5334cf640b37795cc860de4ae2816e95b21be5ceaf
8a49f90b52a51cc6ff3355f47e0237052b81f6800fd7b802239daf6d8f0b1571a8426944fdbe80c6c1d40e8816b88b8569082ab84c36ff0539d4ff6dce591a26
ade1c0a7f669880485fd484582903d284b26fa4e2156cff62e4b9265844c4495c495a9157b440e091bea1ab8aaf7760f4510eaa69a6465c0e04ec69ffb9e65d0
28d44d4e39df9c1a52ecbd3607fee9cec7263328e5d661d3d0e4f62f44acd855ed7ab33cdf7bcb8ae889599bd5c8b3029895b6825696f6af29c239b75a5bb1e6
345e6ee6c28117e73586c1a2214ae1be07e93fb0ff51e133fb65426fa843be0fb515c187064d0cc206a2fa926d3c902e907670048d931db4c1a44959d366ad93
b65abe595f70a75bf03d616c2dd959fc7d4e6317cd99cbcec9c58b34766661c7d6766ca1a9c1b327531486c6f941c638c67cd22a7f75e2a37be0e82db8df9f30
254d30c1372581a1f51c983c80e4b71ccdd28dbf000000ffff0300504b0304140006000800000021000dd1909fb60000001b010000270000007468656d652f74
68656d652f5f72656c732f7468656d654d616e616765722e786d6c2e72656c73848f4d0ac2301484f78277086f6fd3ba109126dd88d0add40384e4350d363f24
51eced0dae2c082e8761be9969bb979dc9136332de3168aa1a083ae995719ac16db8ec8e4052164e89d93b64b060828e6f37ed1567914b284d262452282e3198
720e274a939cd08a54f980ae38a38f56e422a3a641c8bbd048f7757da0f19b017cc524bd62107bd5001996509affb3fd381a89672f1f165dfe514173d9850528
a2c6cce0239baa4c04ca5bbabac4df000000ffff0300504b01022d0014000600080000002100828abc13fa0000001c0200001300000000000000000000000000
000000005b436f6e74656e745f54797065735d2e786d6c504b01022d0014000600080000002100a5d6a7e7c0000000360100000b000000000000000000000000
002b0100005f72656c732f2e72656c73504b01022d00140006000800000021006b799616830000008a0000001c00000000000000000000000000140200007468
656d652f7468656d652f7468656d654d616e616765722e786d6c504b01022d001400060008000000210096b5ade296060000501b000016000000000000000000
00000000d10200007468656d652f7468656d652f7468656d65312e786d6c504b01022d00140006000800000021000dd1909fb60000001b010000270000000000
00000000000000009b0900007468656d652f7468656d652f5f72656c732f7468656d654d616e616765722e786d6c2e72656c73504b050600000000050005005d010000960a00000000}
{\*\colorschememapping 3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d225554462d3822207374616e64616c6f6e653d22796573223f3e0d0a3c613a636c724d
617020786d6c6e733a613d22687474703a2f2f736368656d61732e6f70656e786d6c666f726d6174732e6f72672f64726177696e676d6c2f323030362f6d6169
6e22206267313d226c743122207478313d22646b3122206267323d226c743222207478323d22646b322220616363656e74313d22616363656e74312220616363
656e74323d22616363656e74322220616363656e74333d22616363656e74332220616363656e74343d22616363656e74342220616363656e74353d22616363656e74352220616363656e74363d22616363656e74362220686c696e6b3d22686c696e6b2220666f6c486c696e6b3d22666f6c486c696e6b222f3e}
{\*\latentstyles\lsdstimax267\lsdlockeddef0\lsdsemihiddendef1\lsdunhideuseddef1\lsdqformatdef0\lsdprioritydef99{\lsdlockedexcept \lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority0 \lsdlocked0 Normal;
\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 1;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 2;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 3;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 4;
\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 5;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 6;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 7;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 8;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 9;
\lsdpriority39 \lsdlocked0 toc 1;\lsdpriority39 \lsdlocked0 toc 2;\lsdpriority39 \lsdlocked0 toc 3;\lsdpriority39 \lsdlocked0 toc 4;\lsdpriority39 \lsdlocked0 toc 5;\lsdpriority39 \lsdlocked0 toc 6;\lsdpriority39 \lsdlocked0 toc 7;
\lsdpriority39 \lsdlocked0 toc 8;\lsdpriority39 \lsdlocked0 toc 9;\lsdqformat1 \lsdpriority35 \lsdlocked0 caption;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority10 \lsdlocked0 Title;\lsdpriority1 \lsdlocked0 Default Paragraph Font;
\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority11 \lsdlocked0 Subtitle;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority22 \lsdlocked0 Strong;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority20 \lsdlocked0 Emphasis;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority59 \lsdlocked0 Table Grid;\lsdunhideused0 \lsdlocked0 Placeholder Text;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority1 \lsdlocked0 No Spacing;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority60 \lsdlocked0 Light Shading;\lsdsemihidden0 \lsdunhideused0 \lsdpriority61 \lsdlocked0 Light List;\lsdsemihidden0 \lsdunhideused0 \lsdpriority62 \lsdlocked0 Light Grid;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority63 \lsdlocked0 Medium Shading 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority64 \lsdlocked0 Medium Shading 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority65 \lsdlocked0 Medium List 1;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority66 \lsdlocked0 Medium List 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority67 \lsdlocked0 Medium Grid 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority68 \lsdlocked0 Medium Grid 2;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority69 \lsdlocked0 Medium Grid 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority70 \lsdlocked0 Dark List;\lsdsemihidden0 \lsdunhideused0 \lsdpriority71 \lsdlocked0 Colorful Shading;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority72 \lsdlocked0 Colorful List;\lsdsemihidden0 \lsdunhideused0 \lsdpriority73 \lsdlocked0 Colorful Grid;\lsdsemihidden0 \lsdunhideused0 \lsdpriority60 \lsdlocked0 Light Shading Accent 1;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority61 \lsdlocked0 Light List Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority62 \lsdlocked0 Light Grid Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 1;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority65 \lsdlocked0 Medium List 1 Accent 1;\lsdunhideused0 \lsdlocked0 Revision;
\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority34 \lsdlocked0 List Paragraph;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority29 \lsdlocked0 Quote;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority30 \lsdlocked0 Intense Quote;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority66 \lsdlocked0 Medium List 2 Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 1;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority70 \lsdlocked0 Dark List Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority71 \lsdlocked0 Colorful Shading Accent 1;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority72 \lsdlocked0 Colorful List Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority73 \lsdlocked0 Colorful Grid Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority60 \lsdlocked0 Light Shading Accent 2;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority61 \lsdlocked0 Light List Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority62 \lsdlocked0 Light Grid Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 2;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority65 \lsdlocked0 Medium List 1 Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority66 \lsdlocked0 Medium List 2 Accent 2;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 2;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority70 \lsdlocked0 Dark List Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority71 \lsdlocked0 Colorful Shading Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority72 \lsdlocked0 Colorful List Accent 2;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority73 \lsdlocked0 Colorful Grid Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority60 \lsdlocked0 Light Shading Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority61 \lsdlocked0 Light List Accent 3;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority62 \lsdlocked0 Light Grid Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 3;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority65 \lsdlocked0 Medium List 1 Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority66 \lsdlocked0 Medium List 2 Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 3;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority70 \lsdlocked0 Dark List Accent 3;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority71 \lsdlocked0 Colorful Shading Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority72 \lsdlocked0 Colorful List Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority73 \lsdlocked0 Colorful Grid Accent 3;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority60 \lsdlocked0 Light Shading Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority61 \lsdlocked0 Light List Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority62 \lsdlocked0 Light Grid Accent 4;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority65 \lsdlocked0 Medium List 1 Accent 4;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority66 \lsdlocked0 Medium List 2 Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 4;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority70 \lsdlocked0 Dark List Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority71 \lsdlocked0 Colorful Shading Accent 4;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority72 \lsdlocked0 Colorful List Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority73 \lsdlocked0 Colorful Grid Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority60 \lsdlocked0 Light Shading Accent 5;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority61 \lsdlocked0 Light List Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority62 \lsdlocked0 Light Grid Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 5;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority65 \lsdlocked0 Medium List 1 Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority66 \lsdlocked0 Medium List 2 Accent 5;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 5;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority70 \lsdlocked0 Dark List Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority71 \lsdlocked0 Colorful Shading Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority72 \lsdlocked0 Colorful List Accent 5;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority73 \lsdlocked0 Colorful Grid Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority60 \lsdlocked0 Light Shading Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority61 \lsdlocked0 Light List Accent 6;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority62 \lsdlocked0 Light Grid Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 6;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority65 \lsdlocked0 Medium List 1 Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority66 \lsdlocked0 Medium List 2 Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 6;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority70 \lsdlocked0 Dark List Accent 6;
\lsdsemihidden0 \lsdunhideused0 \lsdpriority71 \lsdlocked0 Colorful Shading Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority72 \lsdlocked0 Colorful List Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority73 \lsdlocked0 Colorful Grid Accent 6;
\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority19 \lsdlocked0 Subtle Emphasis;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority21 \lsdlocked0 Intense Emphasis;
\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority31 \lsdlocked0 Subtle Reference;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority32 \lsdlocked0 Intense Reference;
\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority33 \lsdlocked0 Book Title;\lsdpriority37 \lsdlocked0 Bibliography;\lsdqformat1 \lsdpriority39 \lsdlocked0 TOC Heading;}}{\*\datastore 010500000200000018000000
4d73786d6c322e534158584d4c5265616465722e352e3000000000000000000000060000
d0cf11e0a1b11ae1000000000000000000000000000000003e000300feff090006000000000000000000000001000000010000000000000000100000feffffff00000000feffffff0000000000000000ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
fffffffffffffffffdfffffffeffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffff52006f006f007400200045006e00740072007900000000000000000000000000000000000000000000000000000000000000000000000000000000000000000016000500ffffffffffffffffffffffffec69d9888b8b3d4c859eaf6cd158be0f00000000000000000000000080ff
2066bd74ca01feffffff00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ffffffffffffffffffffffff00000000000000000000000000000000000000000000000000000000
00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ffffffffffffffffffffffff0000000000000000000000000000000000000000000000000000
000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ffffffffffffffffffffffff000000000000000000000000000000000000000000000000
0000000000000000000000000000000000000000000000000105000000000000}}";
        }

        private void button1_Click (object sender, EventArgs e) {
            Close ();
        }
    }
}