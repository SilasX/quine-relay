using System;class Program{public static void Main(){Console.Write(("(defn f[l r](if(>(count r)45)(lazy-seq(cons(str\"    ~\"\"r\"~\"&\")(f l\"\")))(let[c(first l)](if c(f(next l)(if(= c ~\")(str r c c)(str r c)))[(str\"    ~\"\"r\"~\".\")]))))(doall(map #(println(str\"        \"%1))(lazy-cat[\"IDENTIFICATION DIVISION.\"\"PROGRAM-ID. QR.\"\"PROCEDURE DIVISION.\"](cons\"DISPLAY\"(f\"s=(~\"package main;import(~~~\"fmt~~~\";~~~\"strings~~~\");func main(){fmt.Print(~~~\"print~~~~x27~~~\"+strings.Replace(~~~\"import Data.Char@nmain=putStrLn$@~~~~~~~\"procedure main();write(@@@~~~~~~~\"DO,1<-#@~~~~~~~\"++show(length s)++f s 1 0;f(x:t)i c=let v=foldl(@@a x->a*2+(mod x 2))0$take 8$iterate(flip div 2)$Data.Char.ord x in(if mod i 4<1then@~~~~~~~\"PLEASE@~~~~~~~\"else@~~~~~~~\"@~~~~~~~\")++@~~~~~~~\"DO,1SUB#@~~~~~~~\"++show i++@~~~~~~~\"<-#@~~~~~~~\"++show(mod(c-v)256)++@~~~~~~~\"@@@@n@~~~~~~~\"++f t(i+1)v;f[]_ _=@~~~~~~~\"PLEASEREADOUT,1@@@@nPLEASEGIVEUP@@@~~~~~~~\");end@~~~~~~~\";s=(@~~~~~~~\".class public QR@@n.super java/lang/Object@@n.method public static main([Ljava/lang/String;)V@@n.limit stack 2@@ngetstatic java/lang/System/out Ljava/io/PrintStream;@@nldc @@@~~~~~~~\"class QR{public static void main(String[]v){String c[]=new String[8000],y=@@@@@@@~~~~~~~\"@@@@@@@~~~~~~~\",z=y,s=@@@@@@@~~~~~~~\"+q,T+n,J,O,U,F,S,O,B,M+L,D,P,O,T,U,B,i,;+d+j+e+g+d+L,Y+L,J+i,=,D+N,0,2+z,.,4+L,<+c+c,Q,S,h,U,<+f+t+T-C+t-;+c,n,M+k-G-G,O-G+4+q->-A,G-G+L+Q,T-W-N-D-N-<+Z,B,T,T,F,N,C,M,Z-W-B-D,a-G,c+Z,N,F,U,I,P,E-W,t,B,U,J,D-W,W,P,J-z-D+L,-,B,h-G-F-D+U-G,a+Z,F,i,S,Z,Q.2,i-W,M,E,t,S-a-H-b.P.O.R-I,W,B.M.5,V+n,S,F,R,V,J.[.:+S,V.-,M+S-G.=-D+l,V+Z-T.H-D+T+S+O,J,N.F,S,U+m,t,E,J,P+Z,I+o.N/4.Q/5.S/6/9.R,O.k.<-G.o.q-?.s-E.:/7/G/:/H/8-H-<-A-W,N.8-P.t.l.>,Q.h-Z/S/I/Z/K/J/b/[/c/a/I-<.r,U,?.L,h,H.:+q/e/q/d/s/f/u/r/L-=/C,U-V.t+q0-/w0//t00/v/d-<,T,B,Z0-090.010<030>02/q/h,S,P,H,S,B,N-W,1,2.:,P.h/V-o+t.m+t+l,C,F,H.9.5,X-?,j.f,T+[+[,D,I.W+t+L+d+e+[,F-W,Y-{0e,S,Y+w+u,S,L,D+z+i+[0p0r0f0h-W+e+h0n1-.50d+[+Z,8+w,F+{+{,N,U,1,J,,+j,:1?1B1D1F1A1C1E1G1L1J1H1E,M+d1Q1P1O1N1I1X1M1K1Y1A+w1b1U1Z1V1e1W1a+c1>1a1[1f1n1h1o1O,M+c,E+z,S1s1i1{1z1z1l1g2/1c+i,01r,7+h+x,C+z,G+s,R,M,.,D,L,W+t,7,V,T,7+z,J,Z,+,,,E,Q,U,0,9+b1,.50q160e0g0i+L12142T1.+d,S,.+s,Z,6,-,5,5,/+s+u+j+j,G,S,V,X,F2S0j2U0j172X11130o2b2V+[,0,L,,,0,7+x,V,K,J,[23201p3>1j1Q,7+i1q3=3A3G1Y2F,H,,,K+b,.,5,J+y,,,,,4+b,G,P,U,R2,1r3a3F1D3C3E3f3?2+1F2F->3[3c3m1k1m3h3o3r,:1u,E,++u,W1P+y,S,4,I1N+h,S,3+u,:3t3n3b1c3i463c1l,R,W,Y3H3s4A1V+g,G47453g1L25+y,2,Z1y4G4C4;3q4Q4I3i3v1x,4,K,R4U4B492F4T4H3?+g,:+i,W+u,O2E,:+a4N4h+x,W,R+a,M,2,,,F,4,2,I,Q,L,U,/,2,S+w,-,L,++t4F4:4a243D4f1C+s,S+u+b,U+v495:4;,,+y,:,E2e,Q,8,G,0,6,P3z,9+h+z,N,++r+d5U,-,O,.+j,H,3,8,:5+,S+c,7,.,2,K,U,.+c,G,B4>+z,F+z+a+s+e,5+v+z,3,J,C,2,:6-0X,O5C+v+j+{,F+a+f,K,T,3,3,+,C+w,P+v+i+r,/,:-t,-+r,+,/+a,O2N,Y,2,3+{2w--1.3+.52[3.2x1.+Z6,+g+c+a+a4?,H,++j4u5G6q1f4d5F5=1i4h+j,J6r4e1W6t4b7.4D,:+j,K,W+g+z6u7+1{2.6{771I1S,1+x2f+u+u,6,H,L,Z+{+d.h6v7/,N7-4P7<1s4E,Q,W6U,K,0,G,Q597L3u1T787M21,,,3,,,2,9,H5n,R+y,0,K,N7Q7P2-4S77,0,J,3+f,N3P7s7[,J+g,J,h+j7a7[1d7e6v+c+x,:,S,N,N,Y+t,K+j,2,-,-+t,[5,,28=,Y,H8B,C,:,J,G+d,Y,K6X2y+L2{106a3-152z0e6f+v6h+a8V6Z8Z0j6b8b8X8d,5/{,I,B7i,C,V,/+f,3,:,+,G+z,Z,U+a,77;7M7O8.774E,7+y7q,P,Y+r,F,7,Y846r867t9E1X1l,7,M,-7d9F1K4E9M7L254s,O,0,Z+x,8+z,Y,0+t3z957.3e6v5?5B5D8-7;+c,+,E,X,Y8F,Y+x,Q,/,E,9+i+d-D,S3w,H7X,U,Y5x3w+y,U,5,[9L8.9O9c7t3C,Y,3,V9j887v874C1u.c:?7+:892::+i,M9B4f9D:94;8:,S75:G7<7::N:D+d,37W7Y,W,E,38f6i8i306[8l8a3/8c186g:h8n8Y2Y8m:n8o:p:g8h:s2W8k2Z:m6d308e8g:i:o:k;.2a;0:o;2:r:w:t3,;86Y30:Y6u+w+x+d+d:Q5:7>:69C-5,Z+y,G,H,N,R+i+s405L,/,3,B,C+b,H,H,-0X,4+y,J3K:C:W:B9P:D1v,2-w,[+h+w:e3K8z,T,Y:z;4:x;6:v;9:x8e,1,[,F5u4?:V4B:I;D2,4K+d6D+d5?,W<;4G:P:J:R8;8;5d0l,9,W4X,G,K;i,V,++s+i,O+z,W;M5=<:4e,S,1,X43<,;>8[;A8W17;;:{;=;,:u;/;B;::q<n<0<h:l<j6e<u<g<p;?6c<s<1=+;+1/<q<z;1=2<o=4=.=337,9<T,+,[;i+z,+9b1A+y,F=F,1:2,I,[:L,E,H505N,:,62e2u,6,5,H,M22;o7Q9e789g67<87P1l,Q,.<D3=<F=m3p;J3t;L=h=n+i+{8J<G;K7c=u3g+w+j,C7Z=z=s>+;l3s+w=w,8,Y+b,23:7g,4>0=[7J:[0X>,4g58>24A:;6/>F3G<a>M3d+h,.<W6z+d,6<m=,=:<i=/<k8p<+=3<.<r>b:y;3>e;-</=0<l=8<w=->[=3<m+b+j0N,X5,=X,W4N>5=i;n=r1t+d><,[5y>Y>f=6<t>d=9?7>a1.,Z.d3<>I2+=d7<=f9i?-5H,Q,2+x,N,X+s,B+f+f,:76?I4U:X<Z:Z??>P7R>H=p3B>R?d3A=o?Y79+{,V9A?j>6?a1h89,:4s,Z,[+{5?,V?+4O?0?kA,3[1S4M2I+x?6>l>g8j=5?==7:z?t,E?v-5A.3a=t?V3>+w+z,V,92h,-,E+{,.,N7K?o3b94?C?b,FA<29+f,VA4A8>t>p>n>r<yA9?96H,3,[,2,OAQ3F>OAD4J+i+h+h,E,P+h,9+e,O?g1e?i>P89,8+sB+1oB-Aq,,890w,:0h5l,/4>An4IAp=b<<5<B>6s,7BE>N?cBH3dBD?q7N,7?:>q>ZAfAb:g+d,8,6,N.{2J+f,0,-,qBJ?a?EB51M2F2H2u91B23jBGBN9N,F?L,4+vBK?bBB::+h6fBl4.ATAB>47t5u,C,6,X,DBi24;uBo1GB4Bz9G=D,2+cBx4DBfBi9R,W,O+iC81ZBhC>3E2F,M,3,1C.BoACCOAE=w4j4l4n6k,1,G4y,4,/+{+vAc>h?<BU>j?;A5?8=1:g>1CVC1AAC<+i,3,Z,8+y;S,R+s+j,m,J,R7m,4,E2?,0,H,7BnCDBOD=9N,90PC;AS?g7SCx1qCWDH,1C=A,?X?q4WBr1HDOC81S<J;<BRCm=9,V;V+i,I9m+{A+C/9G?/C/3v,+CoDYCqAgCsD9D;DhCPBqCLDA,P+d+y>LDx1BBAA.25.7D?E.CFCX4J26.1,K,++e+b,16,,.;HDK?1C;1c+hE5E0BM4b?G5EE-1C9l+u+w,6,UCKE6?DEJEVBj,7+{,X,Q,REQES+v,Y;P+jA[=;=9>X>kAaEm6,+x+j7JDuBFE38/4o,/Ev7,DwEY7072+x9p,-2;+w+wEEDLDREO+x6P,H3RENB6Dj<D3v,W,V+s+t,O+j,-,P,F,Q,0D2D4,2,RD62?DnAdBS;7Dq<l,G,V,F,YF.1gDJ4aC3C5C7Fe1n25,,F7DM?C?X+h=JBxCNCxBk,J,X,B>;,9?UFlDSFBAQ1S5.,0,X,[+j+b,I,H+zChEC7=CwEv>77IG>1RGA?d+wFVClDpCnDXFWDZBR;;+d+x+i,D+{Et+x.,DS,YGE7bFpGJA7ElBR.x+u+{+e,M+x,I,4,.GDF+G?Fp?l+z6KCkGf>sEq+vD97Y+wG;CeD4F6E3Fq;D89?m:aF9FAGbFgGHH:89,K,F,G,O,F+s,7,:FoH4H??lGsEZEx4E+e43FpH?27EkG{GQ:q;IHNGcH4+i8GEXFxF-46,OAl7G+zH[Cv,E,VGq,h;i;T+jCuCDH=BEH5?jDTF.1uHDHFHHHJDRH{:V1lAPBNDEBH4h+sH<GGHz+i,1<vGOGLH+8g3NHI,02g,2CjBQIDEpBRFpEt8R+xA=,F7p->,Q,3DgB+I,AA1S;f6n+d9I;fHLH<+c,W:z+b+t,Y+z,0+d+i,Q8LFo8M3N,6,M,U+{4p41,KIkHaA0,,,U,Q,7,8,L3w,KEHATFwDh2FJ1J=<;J?=m2F+{,Z+d+t>;,B,3I0,:,/,Z,M4>5A,3Gy:jIEHY8fF?+jJFAnJB,,JD?oJd=uI9>ME/3g<c<e,:HWBTIFGNGKIPFW+Z,HINJwGgJyJX;5JZK.+v,-,3,R+d,4HT7e6z,T,4+i+aHaBO5SIw+b5K,S,2+i;h,:,:2AEa,8,.,J+z+y+s,++d8e,2,H+i,[,.=U,.Iw+t<X+z,Q,H+e3z,:,V6U+x>;,51y0X,W+h,-4[;[,8,4G--v->,V/.,S7p,R,Y,T2f4tI7CLJlAq4hG/EDH468L;BLKA2FK+GzJtJ[GeJYJx>h,FLDLIK-K,HXK2LHK0LJ1.,W,8,I,X,0AV,SCR,H+f,4,S4>,ZIW4ZLBHhF++gKi,W;i,W,0:<,,,I,E,U,2+t,J+f,.,-LMLTLO1.Da+e+a8;+y,X,X,Z8t,/.d:<2D+v,D,YLS<-K1LPLFIOM1;10[+u,X><Ll9LHj,OHlHnHx+d,M818B,KBb,SIv,27T,V+{,KK=,W+f2?,X,9ICMGFYGMMoLEMq=9,MM/MELULNLQ>hEnCpMz:o,R6,,13L+d1x,/,F,Z,7,S,D7W+s+d,K+w,35q+i,BFM,DHj,V,1,N,88:,.+u,B+a,C.{,3,DJvMt>m>h8v,/+dM5,R,E,Y,Y6=+s,2,8,PK4+zMk,q5xMsM{MHMpNY1.Fp+iAl,K+s5p;VHv,5,W6:,YD1.8FQ,NJsMuJ[Ai,8+b,NHPJh1eJp<fEoMJ?9MD<xO8LR+d,/O7Nv;1.1,WMn+b,EFK2:,N,O9?,-+j+t,8N{O,+s6RO/O1,O,M,7,N9[,Q+t+t-?,J7WL?JcHfJALmDFO?>525N-DoN/=15d,:,OB9K99MK;K=K?DDBGFz4j5Q6?,[5u,U,P,I3z7U,G4x6hHR+w,N+{O2NC+i,S,/,S+{EdPKLiOzBBJj?IL8E6JnJE+j<CHKF?89OMA6A:OGAeOIN,6g+f1+ODN+1.,.7x,S3T+xOq4z<P+a,XCS,C,4+wLs?x+eE{,12=+r,W.a,R,R,/+j6i,EP,MIPuA:+r,R+{,6,6IrIaBKIc4I7x7z8+HP,:3Z,O,P?N,[,4Hj,X,U+j+u4+FNPy5y5C,X+z,-,,,8,O<M,T,K+e,G,.,9,P+y+h,KMg,26UNVN?,7,G,3G;NrM0QF:o,EMxOHONR6Nt<{R:PnR<:x3XHF+j,6+{5b,U;[,,,.QVLy,S+y5R,U,+6i+b;i,M9U,J74N2,Q+d,I+f.13;+f9I,EN3+{+z+b,B,H0EQI=XRqRq+b+i,L,L5w6B,,,D=YPmFXRCR;PkOF6i,6+y,W:.+rI<J3I>2+FiC6Jb,71E,P,2+h,++b,S+f,6,R,0,z,:0H,5,1+t2vPtR>Pl+hOLSVPoR?S/GPLR-<PjCr17+z,E,N=l,R61,:=Q,+,0C+K/MyOECsScMFSbNWNsSaPlT+R=T-S4R5SvR7SxT/T4SWT2SgFZ>c6h+b>WHZI=Fp+h35+w+r.d,XPX9cPZ1hELH?,+S78T+r+eMUDPS=AD+w,.TH+uKa5q,0+eSP,5,.+v+t+f2L<W,/,,T3S2Sh0e,FSuTrT<>iT7Tw=3,TRAS0S3:xHTLd+w<cPgL?89S6?+,T+j,3+a7U,,,SQj,WKq+v,G+r+{IUFo,P+aRW,V-uEd,R,L6,,3SO4w,MQNB.G1=h1u>9EbFS,B6,,27?,6,47p,-RVUgU5G>=j,3Ne,L5iTCH4SG>vT;AbO>OtP+6,22LkP9QU,74N9KF9Pc3AOBJrS[S1T=TzRBU/>o+v,4?5V;VAV=TqV?TsTyVIU.VK+i+z,X8M+yL-..V>VNTxSd>hSI<YAjRNLz,FG7+yQY,ORVHt,F+tSZN.SwT{=9,N,6,WF{CiND?BB2TM1XTOPh8:+yP4UpDfPfI3TP5B,H,R56,R=B7k+gU;,S,C,8,S>y;a?2A=Qj,CQYO0O6VFVKVZSb+rPsVpT5VBPITAU-WPT.VMWZ:o0t1xIX8J?N?P+f6++vGq6k6f,5+j,XUN,C+iRM,J=A,0+bWYSz30KQ4,CUMVHT4-UvW5,4<P,9E?,3,C+{6f2O,G2RWNTx>u=lUoGs=j+{W1XF+{,89JV+GESCW4JcNCV17sMRMTIl,E;rFR+wUnW5PhW3XIIbSH622eRVUz=9,6W{P.VrHY,YNV+f,O+a=Z,40l26:5V6TK92SC,BJ1;zPr,L>9NV126f342JVT7qUXB5QPFC+c:FENV7<8Y/J1,D,[7z38XNHNSC,V>EYDY-9Q2p,RXoVq0eE{,55PKU,0.cFM+uMw,J6G+{+iUu8>8M>/II,1+uXlLG+cHR+bKQ+h,3+x,6+wD92qV,Ov3hW-U6+yYsOJ,R,S+b,L,Y,[5?GbD>V6,9,GP8D=Pa1gXV,ZHmIlLbJ2CV+c8;,4PT,GD61y7y+u+aKq9x?zQ=,Z7YP<,6P>.,8e,4OeU4,V,0?+63,N2H,Q+e,U,T2=+uGa,I8e5{,O,G<dKP+f9.,+=k,J4.,I-v295f5h,Y+{ZMX0XEIb,,4[XTYD4i.UTvVJTxFp,3TeZDI8OxI:,94YTE,J+h/yUCYMV{Z0Je[OJm,9+f4=><,G+fGa1KFtV0EO,V,:KP3ZRVIM,-,26DXbE-I4;l1l2sS8,.X9,,8P,H+rLe[BZE[aL9Mn+a,V6,3TX/TWFp0w,NQV,D,j,U,NR9,I/{7y>0?t,I4i5i,79o+rN{QDNuVGVL+b+c,DJgJQ,YS7[XFv>/,6ae6uV9Z5>hXfQO3x+b.2Y,V,+h,,RdAL+eLvSLB6,C+s[n-h+c,2,M+h<W1<FS>0YWWU[HMrCi,X,4?O+f4v3u,VSB[Z1{Z2Up,+9.[CL;+g[Q,J,8,0;TFuBgbFP[BPPI610E9sNR,S.{;Z,B+{Rf,74=Z/Ll8f+t+u+h,P6,U;VgQY,F1o+yYI,2+e,SB9Y=EVY?G2+d80asXOSt+{RYVoP-YX18XY3;98Ue+v+uLf+s6/,Y=MFc,67?+h,:,ZFREr+j+f+b+b,88f+s,/D<[NHPGVX3[x+j8s8u8w;Hb2<W,GJc+y,Bc<,1Hwa>H4+gQ[b-[GVXMr+a,T,95A+fEt.EKP,B4FIU29+eA3XABU,-NgC:+x239>cz5AbE7;bHXF+y+{,L,[2m,Cd5WTT9T6WaX+:oKL;z+a,8,C,LcU;aN<JgJc+x3;Qn+{+uZy3P+hZj,48=+i6icy,9HB7ich,,+u,3,4av4m,1,:Tl,2Ry;zcWMPV6,D+ycXL7a6Pb,:,7alNXaW,77lOR<c+x,1,Sa=DUTXCX[y=bc/U[Im9T9Ve:T,V<VLeP<t,H4M6C,E?T3I6D,Z7UcaC2,WC4SAatGw+z,1LieTdNenWV+cTVeFFpSS=A+u,N2AIt+e,9,D0tX93V,PBl2K+u5LSyXpVHepf8d6JudOf7eSf;Ytf=c:;;+f9haiCG+hRf;TUKf9f?dLT1:xP2cs,1,+U4XcU6+z,8+r>9c-DNUZ1sQR7{8,YD0g,IGUb8dMXqSefCb9>ibw:<;aXD3d?LFE,G,E901k,VQf,I,T9U,,+w6fCSM:+y99,,WW:<PyBj282I,F,VMA+w,Z,T,I[T,0+xHF9aOT,:,F+d+u,K,6/V,1,P,4,J+j7xc3YN+i+wBvf6fDcvWbeofAK.,WK4XKFc5q425Ian5FP6K>Ll5qJ.fNaUe;VK+Z,J,LM97h35,R[K+f4+,Y34,1<Q+w7q6hBWWJZ:Vk,8eV,I,Z,CKu-fLz5DNe;RR[SkM82gbZ:,+r,Cf4O=gbV{fJ,WbSbkP9fnfQeqfrfo8pgLVWgjhhKpgD+hQ6Ut3YdAP9U3Xd8.fgQTV6,K6BN1hfeRh,eQaW,6K5,W,GflS-eC60,2QY>y,RM,,-,MY6Ak,Obm?Qi=,IYI8z,VaD,K5w,7,6+x,9HEe8e0YDbObQfHEY3C+v>9c7+{ERSM+f,+fNhnf:fPi1gidPU0HKX5dgi0aW6f,R6?6=.-2JGaBZ><hZ<b<dOCioixiqf>,5,L8Q2oa4cYj1bULl,+X9,K[o,OI[hyJ3+c>9hHNAiNOZ8;FtLcTQ,.+xYhggfs+j+z+zJ-R[,R9-NJ,F,MLXPyR[+j,S,Hh?+s6f8{Z8ilirhhh+j7ghiwh.<u3N,E,M,R+t;haq,P,TMj,0K8[>4Tgw[Me53X+jhihg0e,C,,,P,[7CeY,R,GZ;2L.7,/,H+u,0+a,K,PNVUL:a,DCTgNVT,10X+fB<,L,08s+y+fV5YRatfK,RFL,8+f7FM9,2J8F1,XL{StjzVYjuinc9fsi2T0ipkzCn+r,ZTm,VK4;aki,QK4,RZsbLHiHkZIesI-+c4Z[tWMj5j{l2=9,-gP83,OQJgnJI66,hFa,1,ENd,GF3,N,W,.lY,V8zdU,P,L;z,2,6,:KqjXhj>i+s1CD7.{cP3Vbi,/0KlhZ:FG+sjwlLfBfNFp,2TT1Ajxl.k++bUQkJiIkC,O,X9++j,8ia3=akglPpm0FW1Cel3M+j,N=QMnjwUAAxSHe3J,cV69a[YS7dW+<GFy,XR[+hguY>99,B0ugG,Ii9,,d8?Q,C,O,HSSgZldk.O-m/lpkAfOl-lql/T8n-k-,/=DaY>0VzFvbVTN5A=gXd53,MJ1mRmHSbPej=e5HP,F+c,NEjnEW[jw4t<U,II2[xH?+y,M,/mDj?fI9+,UFFAk+w0h,U0l+s,0jd,Hd0jU,GDfjICv:a7Xhda56:Eb,8,DNp;U,C,HCI=EhGURmJmIn,l1o6j6o4S{fF83k8UYedDKGCM<iXbM,D,99p.Jl;+x+toElAMSlCoAGBHUnTQX,0fMnOT:oYT6kc,LZp5k,9+yaq,L,G,D5gO<Y9,++x,M,T=Q8JD,Rp;Oop=P+s+fkpD7lbma=cn;:Q2Fe2Lo+e,C+dmEJ>2pJ{o8lKp<XBm7n06,+rck,EgU2O+b,7cz9;aSG8buhv=en=?HU6Srld,T5Y,BGxo:nPo[jvpb8d,Ma18y,.+w,TR-JK,n,8,3,WaSoph5-w,Z,O+hG;,,,H+sJ9Go,-+{Qz,+,D4=,X,:XL,-,.CZn+hml+n.QEpBp[;:mA,DbTCGp0mdE[N85gLfIsTH4k,P,P6nnw?FpREMU6,,+s+xnq/{-Do3p>Mrq:k?eRey,0,E,0,SgU,V9-WtKP[TpP[N,TCT,Z2o,92t,H,I,7q12H?v+jVh-uHvoRGH+w+h,VOjpAn-imq=aVp=q;f>n1fpamH4Dm?QpF,,EgTUrDb:H+,-BmoNLn[Q8B35,+>yi95S,3+e,[,:arkk7[mGlJp?qAgkriCn2;+t,MjZKI[KoW,,+z+t6Ci=G.W2I=+gi-+eE+rSDF,:,4+t+{,OrvIzKarkpcrmf<qfn++t+e?R,G5.>yr-OPrarcf1[<TW,BL1qtEKqUsMetH49aqSe5aF,J=yCvNx7gL[r;o7rBjyqds>pd+[+d,Hr7cVg9iUaFL6FeZF>I4E,F+u,R?TeCsz,Sawg{slr=rNcwsks=m1slt4t36gIA,Bs43Sns[=fXW2M5+uNk,D+rFN+hSC8Rl>a5MQlBZJS<+xtAU6feBzHy>FeI951ltFJ+lN,+X7s;l,q>n-t:q<tmrCsfo9h?+x+y+u,CDm,9,B,I+htir>h-rjsjt8t7fqs?t9:qfFSkp8JE:LIfEtIiu9Ji+h:L5wGk662t[,satC7.S?FkXOpN0htBTWtLTZ,Qttf+ljWSn/tltqrAqgtrshm8u,tosiueq?u0u3u5uguap?NJp.9dqG843JIg9?mic.tX:9tZTYCdsXsv,7J1uQDUCCu?YF+h4LuDYkH3tD6qk:LlOlkw,OBdiz,3>V+eoGIJVtuhufulo5uju[uovTvPS{ucubu4u2vQvXu/vRsgvbAbCJ2;,,,M0EIt+iou+zkP+erpE,bMusB{+xaD8?XK,:iCfcFrv+1Kh{fivu+eqYvys55hiC1<NE,RaDkUvZuZvew?tkwBunvVpav[vWwCr?vcvft6wAaWFprXnZ+sLxelq5AK,JgM,/jh+zwGeUux?nv>Ibw/7av-eHv/XOuu:6Jfv4lE.8naib26NH<TOtHbwhQOwj9L4W1<Az>wv71orhwPvYwFvdudwNu1x7wMwKu.qex9x<umwIwHx>cx5kLwJ.,8cK9T,GQ6jmmv,G,Fvo43HR,4->,2cP26,PN7n9jA9fsSW.KOQL6V,K2o,MQmEh.Uw6x.7swl=rGIx:x8xGoZy+rlxIwOwDx;xAi3x{y/BR+du,t;+velktBYB[,+Bb,WpkfU,O+yhEelrIk-k/W;+y7kW0+tGZtPXUtRlDIdp70{K8cB6z4>bf4x5/;[CiY5xzx?xDy3l0y2ykyoy-s<y6xFysrFI3+uRi0wt0Tl,C5L,.,WgR,O4m5ni86fJTWRsA,/yzuPtWIlNk,W5f[+,9,NN{8GWJ5qSSIwKq50,Soprr,4,4f4,9Lz5f,[3Wx41Px6y1y5z[yjyqtjwLxCzdu-y4u/TH?K5W,Z2C,VRWBYT[7iWC,UFG2B0zojl5g,aRN{id,Y,P,0fUfWnVW.Qfuz20vAP9,Sd8kCcKg7,Bg9J18x,R>;5Lxa+cZy0z,Z,Z+fX;6g2Cyln2wEzhvNq?,+Db.J3Y6Ndt5LDm+t+y+awZ-8+fdb40xUTl,E,4,B50QIv={5U6+x0w,9xL+cCK+fiU,G+cZ+{8FroLs14CZHtSCvhb,+FL,7;H,8Sl,S,KmlgFgHgJgLQHrciC<T+t,Vo3+zkFjpu6g5upAb2OQ/{P:gs/,G8=w>slFpzLzNyYs4RI,UiPgYg[gL+thHD7J{,1,B?2zn2C+a;t-?,ZxE>h42,Z+e,82k7N,Y+e,Y+d{HYuZ85L9xgS9:9<d=pJ,XdJ,S9:9<,F,6+u5.zLF5AErQEQ{u=idtn>pTaz,Rb+b-,:-haSWyG;Yy,V,7+c9A,HQVEQ,NAl,C8R3P,M,V{f,K,19p+tTJ9tZIcogS/QM9[T+v,KiK,[,1au+as6,KeEI-eGxx,,?lNS+a6:b37TcJ,C,W,[,1.c[U-j4>b14y,QC6,j4{4/Rcr5Hze[+{2Os4,V,G1t+u{8FrGY1k,[nHv1tQoPtSZNhbGj,G,U+w,O,+,2+f,GbKyS[DgS/QM9[T6E9-N9,KNe??,T,89tZIco6D,V,[,5KIZi[u:.7?,71vNfgS->NBCeNLRpg/,,,Y,M+gNeUc>?,Q=[2CNS+aDf5lZm6Tkw<Q,B,DYmrp+v,:-hsQv1,SgH2K+f0EG<+{e4v1tQoPtSCv,:MNqNb3J{7zSI+gSMbOg[gL0lg9,s,0+rNP:Mo>Y>{xc+{{B0,-vx+tkts1[PgYbQ8f+rgIs1I:,F,CG86zY643.KxafFh=<Y8R4/gX,KTEgLTkTm6m2Jdt4m,TZCZ8W83xB<gnzXTLhaq2rYg[zX1GzZMp0lVK,GO7aY+fWO;-d,WO>l2RTx0dS[c1WO>l0mk{:u2RTx0dS[c1WO>l8hXB,M.B,H-wO70lVKm.S[0lWO>l8hTx/i-W,Q,B2?O7d,VK,Hjt2YIuWO;-c1VKxEMpaY+fVK13S[aY+dh.fN0dS[aY+gWO;-+g2RTx0dS[c1WO;-aY+fWO;-d,WO>l2RTx+cOM0mk{:u2Rk{:u2Rk{:u2RTxd,O7PrVK+f+dO7-+VKG8O7+g8hTx,OO7c1WO;-PrVK,{O7-+VKPrO7+g8hTx,OO7c1WO>l8hk{:u+fVK,OO7c1WO>l8hk{,SOM0mk{2Y0lVK<UO70lWO>l8hTx,V6R,B2?OM8hTx,T,V,C.LO7+g2RTx,T+ZO7c1WO;-d,WO>l2Rk{2YcPWO;-c1WO>l8hTx,P9{O7+g2RTx,OO7c1WO;-aY+dWO>l2Rk{2YEtVKk?G8WO;-cPWO;-c1WO>l0mk{f>r=,T,QMX,UOM8hTx3W.[,B0gO7d,WO;-0lWO;-0lWO;-+g2RTx0dS[c1WO;-aY+dVK,T,V,C-W,G<,=I,n/=0R/?.BQC0:090A0=0A0=0B+c0:HE,O,E0:,O090A0=0A0=0B+c.l/p0=0A0=0A01-</T0=0A0=0A01-</T.n.[nd,l-W+a/?-r0A0=/4-<.l+Z.[,Q,M,B,D6c+T+[+q+[,H+XNC/C,H+Z2rQY+t8s,S+t-y6c+TQA/T/>/>0=-caZ-K.0.2.40j-G,;7N,qLb60-G,=C{,t-i+Z+t,r,T,P,M,F+k+kN:6z,F,,,h6c+T/lmu.l.[0Q,c/G-<-c+c/T+aS:,9+v,<6j+N,E,F,D,M.V,F-/+d+c-S/W+T-0+V+U,EHC,h,F-/+d+c+q/P,h+T+U,a.+.{+k+Q+a+n,D-K-/+d+c-S/W+T-0+V+L,H-vjg-i.BJ6,U,S-/,OWJ,V,O.K+T,x,z-+---/-1+V,e+X,J+d+c+L+a+X,J+d+c+L+a+U+U.[,U-/+d+c+L+a,c@@@@@@@~~~~~~~\";int i,n,q=0,t;for(n=0;++n<126;)c[n]=@@@@@@@~~~~~~~\"@@@@@@@~~~~~~~\"+(char)n;for(i=0;++i<s.length();){t=s.charAt(i);q=q*75+t-t/64-t/92*5-43;if(i%2>0){y=q<n?c[q]:y;c[n++]=z+=y.charAt(0);System.out.print(z=c[q]);q=0;}}}}@@@~~~~~~~\"@@ninvokevirtual java/io/PrintStream/println(Ljava/lang/String;)V@@nreturn@@n.end method@@n@~~~~~~~\")~~~~x27~~~~n~~~\",~~~\"@~~~\",~~~\"~~~~~~~~~~~\",-1))}~\");u=~\"        ~\";g=(l)->l.replace(/[~~~~~\"]/g,(x)->~\"~~~~~\"+x)\"\"\"))\n(cons\"DISPLAY\"(f\"f=(l)->console.log(~\"(write-line ~~~\"~\"+g(l)+~\"~~~\")~\")\"\"\"))\n(cons\"DISPLAY\"(f\"e=(l)->f(~\".~~~~~~~\"~\"+u+g(l)+~\"~~~\" cr~\")\"\"\"))\n(cons\"DISPLAY\"(f\"d=(l)->e(~\"WRITE(*,*)'~\"+u+l+~\"'~\");d\"\"\"))\n(cons\"DISPLAY\"(f\"d(~\"program QR~\")(~\"print ~~~\"(&~\");i=0\"\"\"))\n(cons\"DISPLAY\"(f\"d(~\"&A,&~\")while i++<s.length\"\"\"))\n(cons\"DISPLAY\"(f\"d(~\"&A)~~~\",&~\");i=0\"\"\"))\n(cons\"DISPLAY\"(f\"d(~\"&char(~\"+s.charCodeAt(i++)+~\"),&~\")while i<s.length\"\"\"))\n(cons\"DISPLAY\"(f\"d(~\"&~~~\"~~~\"~\")(~\"end program QR~\");e(~\"STOP~\");e(~\"END~\");f(~\"bye~\")\"\"\"))[\"STOP RUN.\"])))").Replace("~","\\"));}}