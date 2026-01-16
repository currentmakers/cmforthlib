\
\ @file mce1.fs
\ @brief Memory cipher engine
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief MCE configuration register
\ Address offset: 0x00
\ Reset value: 0x00000010
\

$00000001 constant MCE1_MCE_CR_GLOCK                                \ Global lock
$00000002 constant MCE1_MCE_CR_MKLOCK                               \ Master keys lock
$00000030 constant MCE1_MCE_CR_CIPHERSEL                            \ Cipher selection


\
\ @brief MCE status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant MCE1_MCE_SR_MKVALID                              \ Master key valid
$00000004 constant MCE1_MCE_SR_FMKVALID                             \ Fast master key valid
$00000010 constant MCE1_MCE_SR_ENCDIS                               \ encryption disabled


\
\ @brief MCE illegal access status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000002 constant MCE1_MCE_IASR_IAEF                               \ Illegal access error flag


\
\ @brief MCE illegal access clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000002 constant MCE1_MCE_IACR_IAEF                               \ Illegal access error flag clear


\
\ @brief MCE illegal access interrupt enable register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000002 constant MCE1_MCE_IAIER_IAEIE                             \ Illegal access error interrupt enable


\
\ @brief MCE illegal address register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant MCE1_MCE_IADDR_IADD                              \ Illegal address


\
\ @brief MCE region 1 configuration register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant MCE1_MCE_REGCR1_BREN                             \ Base region enable
$00000600 constant MCE1_MCE_REGCR1_CTXID                            \ Context ID
$0000c000 constant MCE1_MCE_REGCR1_ENC                              \ Encrypted region


\
\ @brief MCE start address for region 1 register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$fffff000 constant MCE1_MCE_SADDR1_BADDSTART                        \ Region address start


\
\ @brief MCE end address for region 1 register
\ Address offset: 0x48
\ Reset value: 0x00000FFF
\

$fffff000 constant MCE1_MCE_EADDR1_BADDEND                          \ Region address end


\
\ @brief MCE region 2 configuration register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant MCE1_MCE_REGCR2_BREN                             \ Base region enable
$00000600 constant MCE1_MCE_REGCR2_CTXID                            \ Context ID
$0000c000 constant MCE1_MCE_REGCR2_ENC                              \ Encrypted region


\
\ @brief MCE start address for region 2 register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$fffff000 constant MCE1_MCE_SADDR2_BADDSTART                        \ Region address start


\
\ @brief MCE end address for region 2 register
\ Address offset: 0x58
\ Reset value: 0x00000FFF
\

$fffff000 constant MCE1_MCE_EADDR2_BADDEND                          \ Region address end


\
\ @brief MCE region 3 configuration register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant MCE1_MCE_REGCR3_BREN                             \ Base region enable
$00000600 constant MCE1_MCE_REGCR3_CTXID                            \ Context ID
$0000c000 constant MCE1_MCE_REGCR3_ENC                              \ Encrypted region


\
\ @brief MCE start address for region 3 register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$fffff000 constant MCE1_MCE_SADDR3_BADDSTART                        \ Region address start


\
\ @brief MCE end address for region 3 register
\ Address offset: 0x68
\ Reset value: 0x00000FFF
\

$fffff000 constant MCE1_MCE_EADDR3_BADDEND                          \ Region address end


\
\ @brief MCE region 4 configuration register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant MCE1_MCE_REGCR4_BREN                             \ Base region enable
$00000600 constant MCE1_MCE_REGCR4_CTXID                            \ Context ID
$0000c000 constant MCE1_MCE_REGCR4_ENC                              \ Encrypted region


\
\ @brief MCE start address for region 4 register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$fffff000 constant MCE1_MCE_SADDR4_BADDSTART                        \ Region address start


\
\ @brief MCE end address for region 4 register
\ Address offset: 0x78
\ Reset value: 0x00000FFF
\

$fffff000 constant MCE1_MCE_EADDR4_BADDEND                          \ Region address end


\
\ @brief .MCE master key 0
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant MCE1_MCE_MKEYR0_MKEY0                            \ Master key bit 0 (i = 31 to 0)
$00000002 constant MCE1_MCE_MKEYR0_MKEY1                            \ Master key bit 1 (i = 31 to 0)
$00000004 constant MCE1_MCE_MKEYR0_MKEY2                            \ Master key bit 2 (i = 31 to 0)
$00000008 constant MCE1_MCE_MKEYR0_MKEY3                            \ Master key bit 3 (i = 31 to 0)
$00000010 constant MCE1_MCE_MKEYR0_MKEY4                            \ Master key bit 4 (i = 31 to 0)
$00000020 constant MCE1_MCE_MKEYR0_MKEY5                            \ Master key bit 5 (i = 31 to 0)
$00000040 constant MCE1_MCE_MKEYR0_MKEY6                            \ Master key bit 6 (i = 31 to 0)
$00000080 constant MCE1_MCE_MKEYR0_MKEY7                            \ Master key bit 7 (i = 31 to 0)
$00000100 constant MCE1_MCE_MKEYR0_MKEY8                            \ Master key bit 8 (i = 31 to 0)
$00000200 constant MCE1_MCE_MKEYR0_MKEY9                            \ Master key bit 9 (i = 31 to 0)
$00000400 constant MCE1_MCE_MKEYR0_MKEY10                           \ Master key bit 10 (i = 31 to 0)
$00000800 constant MCE1_MCE_MKEYR0_MKEY11                           \ Master key bit 11 (i = 31 to 0)
$00001000 constant MCE1_MCE_MKEYR0_MKEY12                           \ Master key bit 12 (i = 31 to 0)
$00002000 constant MCE1_MCE_MKEYR0_MKEY13                           \ Master key bit 13 (i = 31 to 0)
$00004000 constant MCE1_MCE_MKEYR0_MKEY14                           \ Master key bit 14 (i = 31 to 0)
$00008000 constant MCE1_MCE_MKEYR0_MKEY15                           \ Master key bit 15 (i = 31 to 0)
$00010000 constant MCE1_MCE_MKEYR0_MKEY16                           \ Master key bit 16 (i = 31 to 0)
$00020000 constant MCE1_MCE_MKEYR0_MKEY17                           \ Master key bit 17 (i = 31 to 0)
$00040000 constant MCE1_MCE_MKEYR0_MKEY18                           \ Master key bit 18 (i = 31 to 0)
$00080000 constant MCE1_MCE_MKEYR0_MKEY19                           \ Master key bit 19 (i = 31 to 0)
$00100000 constant MCE1_MCE_MKEYR0_MKEY20                           \ Master key bit 20 (i = 31 to 0)
$00200000 constant MCE1_MCE_MKEYR0_MKEY21                           \ Master key bit 21 (i = 31 to 0)
$00400000 constant MCE1_MCE_MKEYR0_MKEY22                           \ Master key bit 22 (i = 31 to 0)
$00800000 constant MCE1_MCE_MKEYR0_MKEY23                           \ Master key bit 23 (i = 31 to 0)
$01000000 constant MCE1_MCE_MKEYR0_MKEY24                           \ Master key bit 24 (i = 31 to 0)
$02000000 constant MCE1_MCE_MKEYR0_MKEY25                           \ Master key bit 25 (i = 31 to 0)
$04000000 constant MCE1_MCE_MKEYR0_MKEY26                           \ Master key bit 26 (i = 31 to 0)
$08000000 constant MCE1_MCE_MKEYR0_MKEY27                           \ Master key bit 27 (i = 31 to 0)
$10000000 constant MCE1_MCE_MKEYR0_MKEY28                           \ Master key bit 28 (i = 31 to 0)
$20000000 constant MCE1_MCE_MKEYR0_MKEY29                           \ Master key bit 29 (i = 31 to 0)
$40000000 constant MCE1_MCE_MKEYR0_MKEY30                           \ Master key bit 30 (i = 31 to 0)
$80000000 constant MCE1_MCE_MKEYR0_MKEY31                           \ Master key bit 31 (i = 31 to 0)


\
\ @brief .MCE master key 1
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000001 constant MCE1_MCE_MKEYR1_MKEY32                           \ Master key bit 32 (i = 31 to 0)
$00000002 constant MCE1_MCE_MKEYR1_MKEY33                           \ Master key bit 33 (i = 31 to 0)
$00000004 constant MCE1_MCE_MKEYR1_MKEY34                           \ Master key bit 34 (i = 31 to 0)
$00000008 constant MCE1_MCE_MKEYR1_MKEY35                           \ Master key bit 35 (i = 31 to 0)
$00000010 constant MCE1_MCE_MKEYR1_MKEY36                           \ Master key bit 36 (i = 31 to 0)
$00000020 constant MCE1_MCE_MKEYR1_MKEY37                           \ Master key bit 37 (i = 31 to 0)
$00000040 constant MCE1_MCE_MKEYR1_MKEY38                           \ Master key bit 38 (i = 31 to 0)
$00000080 constant MCE1_MCE_MKEYR1_MKEY39                           \ Master key bit 39 (i = 31 to 0)
$00000100 constant MCE1_MCE_MKEYR1_MKEY40                           \ Master key bit 40 (i = 31 to 0)
$00000200 constant MCE1_MCE_MKEYR1_MKEY41                           \ Master key bit 41 (i = 31 to 0)
$00000400 constant MCE1_MCE_MKEYR1_MKEY42                           \ Master key bit 42 (i = 31 to 0)
$00000800 constant MCE1_MCE_MKEYR1_MKEY43                           \ Master key bit 43 (i = 31 to 0)
$00001000 constant MCE1_MCE_MKEYR1_MKEY44                           \ Master key bit 44 (i = 31 to 0)
$00002000 constant MCE1_MCE_MKEYR1_MKEY45                           \ Master key bit 45 (i = 31 to 0)
$00004000 constant MCE1_MCE_MKEYR1_MKEY46                           \ Master key bit 46 (i = 31 to 0)
$00008000 constant MCE1_MCE_MKEYR1_MKEY47                           \ Master key bit 47 (i = 31 to 0)
$00010000 constant MCE1_MCE_MKEYR1_MKEY48                           \ Master key bit 48 (i = 31 to 0)
$00020000 constant MCE1_MCE_MKEYR1_MKEY49                           \ Master key bit 49 (i = 31 to 0)
$00040000 constant MCE1_MCE_MKEYR1_MKEY50                           \ Master key bit 50 (i = 31 to 0)
$00080000 constant MCE1_MCE_MKEYR1_MKEY51                           \ Master key bit 51 (i = 31 to 0)
$00100000 constant MCE1_MCE_MKEYR1_MKEY52                           \ Master key bit 52 (i = 31 to 0)
$00200000 constant MCE1_MCE_MKEYR1_MKEY53                           \ Master key bit 53 (i = 31 to 0)
$00400000 constant MCE1_MCE_MKEYR1_MKEY54                           \ Master key bit 54 (i = 31 to 0)
$00800000 constant MCE1_MCE_MKEYR1_MKEY55                           \ Master key bit 55 (i = 31 to 0)
$01000000 constant MCE1_MCE_MKEYR1_MKEY56                           \ Master key bit 56 (i = 31 to 0)
$02000000 constant MCE1_MCE_MKEYR1_MKEY57                           \ Master key bit 57 (i = 31 to 0)
$04000000 constant MCE1_MCE_MKEYR1_MKEY58                           \ Master key bit 58 (i = 31 to 0)
$08000000 constant MCE1_MCE_MKEYR1_MKEY59                           \ Master key bit 59 (i = 31 to 0)
$10000000 constant MCE1_MCE_MKEYR1_MKEY60                           \ Master key bit 60 (i = 31 to 0)
$20000000 constant MCE1_MCE_MKEYR1_MKEY61                           \ Master key bit 61 (i = 31 to 0)
$40000000 constant MCE1_MCE_MKEYR1_MKEY62                           \ Master key bit 62 (i = 31 to 0)
$80000000 constant MCE1_MCE_MKEYR1_MKEY63                           \ Master key bit 63 (i = 31 to 0)


\
\ @brief .MCE master key 2
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000001 constant MCE1_MCE_MKEYR2_MKEY64                           \ Master key bit 64 (i = 31 to 0)
$00000002 constant MCE1_MCE_MKEYR2_MKEY65                           \ Master key bit 65 (i = 31 to 0)
$00000004 constant MCE1_MCE_MKEYR2_MKEY66                           \ Master key bit 66 (i = 31 to 0)
$00000008 constant MCE1_MCE_MKEYR2_MKEY67                           \ Master key bit 67 (i = 31 to 0)
$00000010 constant MCE1_MCE_MKEYR2_MKEY68                           \ Master key bit 68 (i = 31 to 0)
$00000020 constant MCE1_MCE_MKEYR2_MKEY69                           \ Master key bit 69 (i = 31 to 0)
$00000040 constant MCE1_MCE_MKEYR2_MKEY70                           \ Master key bit 70 (i = 31 to 0)
$00000080 constant MCE1_MCE_MKEYR2_MKEY71                           \ Master key bit 71 (i = 31 to 0)
$00000100 constant MCE1_MCE_MKEYR2_MKEY72                           \ Master key bit 72 (i = 31 to 0)
$00000200 constant MCE1_MCE_MKEYR2_MKEY73                           \ Master key bit 73 (i = 31 to 0)
$00000400 constant MCE1_MCE_MKEYR2_MKEY74                           \ Master key bit 74 (i = 31 to 0)
$00000800 constant MCE1_MCE_MKEYR2_MKEY75                           \ Master key bit 75 (i = 31 to 0)
$00001000 constant MCE1_MCE_MKEYR2_MKEY76                           \ Master key bit 76 (i = 31 to 0)
$00002000 constant MCE1_MCE_MKEYR2_MKEY77                           \ Master key bit 77 (i = 31 to 0)
$00004000 constant MCE1_MCE_MKEYR2_MKEY78                           \ Master key bit 78 (i = 31 to 0)
$00008000 constant MCE1_MCE_MKEYR2_MKEY79                           \ Master key bit 79 (i = 31 to 0)
$00010000 constant MCE1_MCE_MKEYR2_MKEY80                           \ Master key bit 80 (i = 31 to 0)
$00020000 constant MCE1_MCE_MKEYR2_MKEY81                           \ Master key bit 81 (i = 31 to 0)
$00040000 constant MCE1_MCE_MKEYR2_MKEY82                           \ Master key bit 82 (i = 31 to 0)
$00080000 constant MCE1_MCE_MKEYR2_MKEY83                           \ Master key bit 83 (i = 31 to 0)
$00100000 constant MCE1_MCE_MKEYR2_MKEY84                           \ Master key bit 84 (i = 31 to 0)
$00200000 constant MCE1_MCE_MKEYR2_MKEY85                           \ Master key bit 85 (i = 31 to 0)
$00400000 constant MCE1_MCE_MKEYR2_MKEY86                           \ Master key bit 86 (i = 31 to 0)
$00800000 constant MCE1_MCE_MKEYR2_MKEY87                           \ Master key bit 87 (i = 31 to 0)
$01000000 constant MCE1_MCE_MKEYR2_MKEY88                           \ Master key bit 88 (i = 31 to 0)
$02000000 constant MCE1_MCE_MKEYR2_MKEY89                           \ Master key bit 89 (i = 31 to 0)
$04000000 constant MCE1_MCE_MKEYR2_MKEY90                           \ Master key bit 90 (i = 31 to 0)
$08000000 constant MCE1_MCE_MKEYR2_MKEY91                           \ Master key bit 91 (i = 31 to 0)
$10000000 constant MCE1_MCE_MKEYR2_MKEY92                           \ Master key bit 92 (i = 31 to 0)
$20000000 constant MCE1_MCE_MKEYR2_MKEY93                           \ Master key bit 93 (i = 31 to 0)
$40000000 constant MCE1_MCE_MKEYR2_MKEY94                           \ Master key bit 94 (i = 31 to 0)
$80000000 constant MCE1_MCE_MKEYR2_MKEY95                           \ Master key bit 95 (i = 31 to 0)


\
\ @brief .MCE master key 3
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000001 constant MCE1_MCE_MKEYR3_MKEY96                           \ Master key bit 96 (i = 31 to 0)
$00000002 constant MCE1_MCE_MKEYR3_MKEY97                           \ Master key bit 97 (i = 31 to 0)
$00000004 constant MCE1_MCE_MKEYR3_MKEY98                           \ Master key bit 98 (i = 31 to 0)
$00000008 constant MCE1_MCE_MKEYR3_MKEY99                           \ Master key bit 99 (i = 31 to 0)
$00000010 constant MCE1_MCE_MKEYR3_MKEY100                          \ Master key bit 100 (i = 31 to 0)
$00000020 constant MCE1_MCE_MKEYR3_MKEY101                          \ Master key bit 101 (i = 31 to 0)
$00000040 constant MCE1_MCE_MKEYR3_MKEY102                          \ Master key bit 102 (i = 31 to 0)
$00000080 constant MCE1_MCE_MKEYR3_MKEY103                          \ Master key bit 103 (i = 31 to 0)
$00000100 constant MCE1_MCE_MKEYR3_MKEY104                          \ Master key bit 104 (i = 31 to 0)
$00000200 constant MCE1_MCE_MKEYR3_MKEY105                          \ Master key bit 105 (i = 31 to 0)
$00000400 constant MCE1_MCE_MKEYR3_MKEY106                          \ Master key bit 106 (i = 31 to 0)
$00000800 constant MCE1_MCE_MKEYR3_MKEY107                          \ Master key bit 107 (i = 31 to 0)
$00001000 constant MCE1_MCE_MKEYR3_MKEY108                          \ Master key bit 108 (i = 31 to 0)
$00002000 constant MCE1_MCE_MKEYR3_MKEY109                          \ Master key bit 109 (i = 31 to 0)
$00004000 constant MCE1_MCE_MKEYR3_MKEY110                          \ Master key bit 110 (i = 31 to 0)
$00008000 constant MCE1_MCE_MKEYR3_MKEY111                          \ Master key bit 111 (i = 31 to 0)
$00010000 constant MCE1_MCE_MKEYR3_MKEY112                          \ Master key bit 112 (i = 31 to 0)
$00020000 constant MCE1_MCE_MKEYR3_MKEY113                          \ Master key bit 113 (i = 31 to 0)
$00040000 constant MCE1_MCE_MKEYR3_MKEY114                          \ Master key bit 114 (i = 31 to 0)
$00080000 constant MCE1_MCE_MKEYR3_MKEY115                          \ Master key bit 115 (i = 31 to 0)
$00100000 constant MCE1_MCE_MKEYR3_MKEY116                          \ Master key bit 116 (i = 31 to 0)
$00200000 constant MCE1_MCE_MKEYR3_MKEY117                          \ Master key bit 117 (i = 31 to 0)
$00400000 constant MCE1_MCE_MKEYR3_MKEY118                          \ Master key bit 118 (i = 31 to 0)
$00800000 constant MCE1_MCE_MKEYR3_MKEY119                          \ Master key bit 119 (i = 31 to 0)
$01000000 constant MCE1_MCE_MKEYR3_MKEY120                          \ Master key bit 120 (i = 31 to 0)
$02000000 constant MCE1_MCE_MKEYR3_MKEY121                          \ Master key bit 121 (i = 31 to 0)
$04000000 constant MCE1_MCE_MKEYR3_MKEY122                          \ Master key bit 122 (i = 31 to 0)
$08000000 constant MCE1_MCE_MKEYR3_MKEY123                          \ Master key bit 123 (i = 31 to 0)
$10000000 constant MCE1_MCE_MKEYR3_MKEY124                          \ Master key bit 124 (i = 31 to 0)
$20000000 constant MCE1_MCE_MKEYR3_MKEY125                          \ Master key bit 125 (i = 31 to 0)
$40000000 constant MCE1_MCE_MKEYR3_MKEY126                          \ Master key bit 126 (i = 31 to 0)
$80000000 constant MCE1_MCE_MKEYR3_MKEY127                          \ Master key bit 127 (i = 31 to 0)


\
\ @brief .MCE master key 4
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$00000001 constant MCE1_MCE_MKEYR4_MKEY128                          \ Master key bit 128 (i = 31 to 0)
$00000002 constant MCE1_MCE_MKEYR4_MKEY129                          \ Master key bit 129 (i = 31 to 0)
$00000004 constant MCE1_MCE_MKEYR4_MKEY130                          \ Master key bit 130 (i = 31 to 0)
$00000008 constant MCE1_MCE_MKEYR4_MKEY131                          \ Master key bit 131 (i = 31 to 0)
$00000010 constant MCE1_MCE_MKEYR4_MKEY132                          \ Master key bit 132 (i = 31 to 0)
$00000020 constant MCE1_MCE_MKEYR4_MKEY133                          \ Master key bit 133 (i = 31 to 0)
$00000040 constant MCE1_MCE_MKEYR4_MKEY134                          \ Master key bit 134 (i = 31 to 0)
$00000080 constant MCE1_MCE_MKEYR4_MKEY135                          \ Master key bit 135 (i = 31 to 0)
$00000100 constant MCE1_MCE_MKEYR4_MKEY136                          \ Master key bit 136 (i = 31 to 0)
$00000200 constant MCE1_MCE_MKEYR4_MKEY137                          \ Master key bit 137 (i = 31 to 0)
$00000400 constant MCE1_MCE_MKEYR4_MKEY138                          \ Master key bit 138 (i = 31 to 0)
$00000800 constant MCE1_MCE_MKEYR4_MKEY139                          \ Master key bit 139 (i = 31 to 0)
$00001000 constant MCE1_MCE_MKEYR4_MKEY140                          \ Master key bit 140 (i = 31 to 0)
$00002000 constant MCE1_MCE_MKEYR4_MKEY141                          \ Master key bit 141 (i = 31 to 0)
$00004000 constant MCE1_MCE_MKEYR4_MKEY142                          \ Master key bit 142 (i = 31 to 0)
$00008000 constant MCE1_MCE_MKEYR4_MKEY143                          \ Master key bit 143 (i = 31 to 0)
$00010000 constant MCE1_MCE_MKEYR4_MKEY144                          \ Master key bit 144 (i = 31 to 0)
$00020000 constant MCE1_MCE_MKEYR4_MKEY145                          \ Master key bit 145 (i = 31 to 0)
$00040000 constant MCE1_MCE_MKEYR4_MKEY146                          \ Master key bit 146 (i = 31 to 0)
$00080000 constant MCE1_MCE_MKEYR4_MKEY147                          \ Master key bit 147 (i = 31 to 0)
$00100000 constant MCE1_MCE_MKEYR4_MKEY148                          \ Master key bit 148 (i = 31 to 0)
$00200000 constant MCE1_MCE_MKEYR4_MKEY149                          \ Master key bit 149 (i = 31 to 0)
$00400000 constant MCE1_MCE_MKEYR4_MKEY150                          \ Master key bit 150 (i = 31 to 0)
$00800000 constant MCE1_MCE_MKEYR4_MKEY151                          \ Master key bit 151 (i = 31 to 0)
$01000000 constant MCE1_MCE_MKEYR4_MKEY152                          \ Master key bit 152 (i = 31 to 0)
$02000000 constant MCE1_MCE_MKEYR4_MKEY153                          \ Master key bit 153 (i = 31 to 0)
$04000000 constant MCE1_MCE_MKEYR4_MKEY154                          \ Master key bit 154 (i = 31 to 0)
$08000000 constant MCE1_MCE_MKEYR4_MKEY155                          \ Master key bit 155 (i = 31 to 0)
$10000000 constant MCE1_MCE_MKEYR4_MKEY156                          \ Master key bit 156 (i = 31 to 0)
$20000000 constant MCE1_MCE_MKEYR4_MKEY157                          \ Master key bit 157 (i = 31 to 0)
$40000000 constant MCE1_MCE_MKEYR4_MKEY158                          \ Master key bit 158 (i = 31 to 0)
$80000000 constant MCE1_MCE_MKEYR4_MKEY159                          \ Master key bit 159 (i = 31 to 0)


\
\ @brief .MCE master key 5
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$00000001 constant MCE1_MCE_MKEYR5_MKEY160                          \ Master key bit 160 (i = 31 to 0)
$00000002 constant MCE1_MCE_MKEYR5_MKEY161                          \ Master key bit 161 (i = 31 to 0)
$00000004 constant MCE1_MCE_MKEYR5_MKEY162                          \ Master key bit 162 (i = 31 to 0)
$00000008 constant MCE1_MCE_MKEYR5_MKEY163                          \ Master key bit 163 (i = 31 to 0)
$00000010 constant MCE1_MCE_MKEYR5_MKEY164                          \ Master key bit 164 (i = 31 to 0)
$00000020 constant MCE1_MCE_MKEYR5_MKEY165                          \ Master key bit 165 (i = 31 to 0)
$00000040 constant MCE1_MCE_MKEYR5_MKEY166                          \ Master key bit 166 (i = 31 to 0)
$00000080 constant MCE1_MCE_MKEYR5_MKEY167                          \ Master key bit 167 (i = 31 to 0)
$00000100 constant MCE1_MCE_MKEYR5_MKEY168                          \ Master key bit 168 (i = 31 to 0)
$00000200 constant MCE1_MCE_MKEYR5_MKEY169                          \ Master key bit 169 (i = 31 to 0)
$00000400 constant MCE1_MCE_MKEYR5_MKEY170                          \ Master key bit 170 (i = 31 to 0)
$00000800 constant MCE1_MCE_MKEYR5_MKEY171                          \ Master key bit 171 (i = 31 to 0)
$00001000 constant MCE1_MCE_MKEYR5_MKEY172                          \ Master key bit 172 (i = 31 to 0)
$00002000 constant MCE1_MCE_MKEYR5_MKEY173                          \ Master key bit 173 (i = 31 to 0)
$00004000 constant MCE1_MCE_MKEYR5_MKEY174                          \ Master key bit 174 (i = 31 to 0)
$00008000 constant MCE1_MCE_MKEYR5_MKEY175                          \ Master key bit 175 (i = 31 to 0)
$00010000 constant MCE1_MCE_MKEYR5_MKEY176                          \ Master key bit 176 (i = 31 to 0)
$00020000 constant MCE1_MCE_MKEYR5_MKEY177                          \ Master key bit 177 (i = 31 to 0)
$00040000 constant MCE1_MCE_MKEYR5_MKEY178                          \ Master key bit 178 (i = 31 to 0)
$00080000 constant MCE1_MCE_MKEYR5_MKEY179                          \ Master key bit 179 (i = 31 to 0)
$00100000 constant MCE1_MCE_MKEYR5_MKEY180                          \ Master key bit 180 (i = 31 to 0)
$00200000 constant MCE1_MCE_MKEYR5_MKEY181                          \ Master key bit 181 (i = 31 to 0)
$00400000 constant MCE1_MCE_MKEYR5_MKEY182                          \ Master key bit 182 (i = 31 to 0)
$00800000 constant MCE1_MCE_MKEYR5_MKEY183                          \ Master key bit 183 (i = 31 to 0)
$01000000 constant MCE1_MCE_MKEYR5_MKEY184                          \ Master key bit 184 (i = 31 to 0)
$02000000 constant MCE1_MCE_MKEYR5_MKEY185                          \ Master key bit 185 (i = 31 to 0)
$04000000 constant MCE1_MCE_MKEYR5_MKEY186                          \ Master key bit 186 (i = 31 to 0)
$08000000 constant MCE1_MCE_MKEYR5_MKEY187                          \ Master key bit 187 (i = 31 to 0)
$10000000 constant MCE1_MCE_MKEYR5_MKEY188                          \ Master key bit 188 (i = 31 to 0)
$20000000 constant MCE1_MCE_MKEYR5_MKEY189                          \ Master key bit 189 (i = 31 to 0)
$40000000 constant MCE1_MCE_MKEYR5_MKEY190                          \ Master key bit 190 (i = 31 to 0)
$80000000 constant MCE1_MCE_MKEYR5_MKEY191                          \ Master key bit 191 (i = 31 to 0)


\
\ @brief .MCE master key 6
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$00000001 constant MCE1_MCE_MKEYR6_MKEY192                          \ Master key bit 192 (i = 31 to 0)
$00000002 constant MCE1_MCE_MKEYR6_MKEY193                          \ Master key bit 193 (i = 31 to 0)
$00000004 constant MCE1_MCE_MKEYR6_MKEY194                          \ Master key bit 194 (i = 31 to 0)
$00000008 constant MCE1_MCE_MKEYR6_MKEY195                          \ Master key bit 195 (i = 31 to 0)
$00000010 constant MCE1_MCE_MKEYR6_MKEY196                          \ Master key bit 196 (i = 31 to 0)
$00000020 constant MCE1_MCE_MKEYR6_MKEY197                          \ Master key bit 197 (i = 31 to 0)
$00000040 constant MCE1_MCE_MKEYR6_MKEY198                          \ Master key bit 198 (i = 31 to 0)
$00000080 constant MCE1_MCE_MKEYR6_MKEY199                          \ Master key bit 199 (i = 31 to 0)
$00000100 constant MCE1_MCE_MKEYR6_MKEY200                          \ Master key bit 200 (i = 31 to 0)
$00000200 constant MCE1_MCE_MKEYR6_MKEY201                          \ Master key bit 201 (i = 31 to 0)
$00000400 constant MCE1_MCE_MKEYR6_MKEY202                          \ Master key bit 202 (i = 31 to 0)
$00000800 constant MCE1_MCE_MKEYR6_MKEY203                          \ Master key bit 203 (i = 31 to 0)
$00001000 constant MCE1_MCE_MKEYR6_MKEY204                          \ Master key bit 204 (i = 31 to 0)
$00002000 constant MCE1_MCE_MKEYR6_MKEY205                          \ Master key bit 205 (i = 31 to 0)
$00004000 constant MCE1_MCE_MKEYR6_MKEY206                          \ Master key bit 206 (i = 31 to 0)
$00008000 constant MCE1_MCE_MKEYR6_MKEY207                          \ Master key bit 207 (i = 31 to 0)
$00010000 constant MCE1_MCE_MKEYR6_MKEY208                          \ Master key bit 208 (i = 31 to 0)
$00020000 constant MCE1_MCE_MKEYR6_MKEY209                          \ Master key bit 209 (i = 31 to 0)
$00040000 constant MCE1_MCE_MKEYR6_MKEY210                          \ Master key bit 210 (i = 31 to 0)
$00080000 constant MCE1_MCE_MKEYR6_MKEY211                          \ Master key bit 211 (i = 31 to 0)
$00100000 constant MCE1_MCE_MKEYR6_MKEY212                          \ Master key bit 212 (i = 31 to 0)
$00200000 constant MCE1_MCE_MKEYR6_MKEY213                          \ Master key bit 213 (i = 31 to 0)
$00400000 constant MCE1_MCE_MKEYR6_MKEY214                          \ Master key bit 214 (i = 31 to 0)
$00800000 constant MCE1_MCE_MKEYR6_MKEY215                          \ Master key bit 215 (i = 31 to 0)
$01000000 constant MCE1_MCE_MKEYR6_MKEY216                          \ Master key bit 216 (i = 31 to 0)
$02000000 constant MCE1_MCE_MKEYR6_MKEY217                          \ Master key bit 217 (i = 31 to 0)
$04000000 constant MCE1_MCE_MKEYR6_MKEY218                          \ Master key bit 218 (i = 31 to 0)
$08000000 constant MCE1_MCE_MKEYR6_MKEY219                          \ Master key bit 219 (i = 31 to 0)
$10000000 constant MCE1_MCE_MKEYR6_MKEY220                          \ Master key bit 220 (i = 31 to 0)
$20000000 constant MCE1_MCE_MKEYR6_MKEY221                          \ Master key bit 221 (i = 31 to 0)
$40000000 constant MCE1_MCE_MKEYR6_MKEY222                          \ Master key bit 222 (i = 31 to 0)
$80000000 constant MCE1_MCE_MKEYR6_MKEY223                          \ Master key bit 223 (i = 31 to 0)


\
\ @brief .MCE master key 7
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000001 constant MCE1_MCE_MKEYR7_MKEY224                          \ Master key bit 224 (i = 31 to 0)
$00000002 constant MCE1_MCE_MKEYR7_MKEY225                          \ Master key bit 225 (i = 31 to 0)
$00000004 constant MCE1_MCE_MKEYR7_MKEY226                          \ Master key bit 226 (i = 31 to 0)
$00000008 constant MCE1_MCE_MKEYR7_MKEY227                          \ Master key bit 227 (i = 31 to 0)
$00000010 constant MCE1_MCE_MKEYR7_MKEY228                          \ Master key bit 228 (i = 31 to 0)
$00000020 constant MCE1_MCE_MKEYR7_MKEY229                          \ Master key bit 229 (i = 31 to 0)
$00000040 constant MCE1_MCE_MKEYR7_MKEY230                          \ Master key bit 230 (i = 31 to 0)
$00000080 constant MCE1_MCE_MKEYR7_MKEY231                          \ Master key bit 231 (i = 31 to 0)
$00000100 constant MCE1_MCE_MKEYR7_MKEY232                          \ Master key bit 232 (i = 31 to 0)
$00000200 constant MCE1_MCE_MKEYR7_MKEY233                          \ Master key bit 233 (i = 31 to 0)
$00000400 constant MCE1_MCE_MKEYR7_MKEY234                          \ Master key bit 234 (i = 31 to 0)
$00000800 constant MCE1_MCE_MKEYR7_MKEY235                          \ Master key bit 235 (i = 31 to 0)
$00001000 constant MCE1_MCE_MKEYR7_MKEY236                          \ Master key bit 236 (i = 31 to 0)
$00002000 constant MCE1_MCE_MKEYR7_MKEY237                          \ Master key bit 237 (i = 31 to 0)
$00004000 constant MCE1_MCE_MKEYR7_MKEY238                          \ Master key bit 238 (i = 31 to 0)
$00008000 constant MCE1_MCE_MKEYR7_MKEY239                          \ Master key bit 239 (i = 31 to 0)
$00010000 constant MCE1_MCE_MKEYR7_MKEY240                          \ Master key bit 240 (i = 31 to 0)
$00020000 constant MCE1_MCE_MKEYR7_MKEY241                          \ Master key bit 241 (i = 31 to 0)
$00040000 constant MCE1_MCE_MKEYR7_MKEY242                          \ Master key bit 242 (i = 31 to 0)
$00080000 constant MCE1_MCE_MKEYR7_MKEY243                          \ Master key bit 243 (i = 31 to 0)
$00100000 constant MCE1_MCE_MKEYR7_MKEY244                          \ Master key bit 244 (i = 31 to 0)
$00200000 constant MCE1_MCE_MKEYR7_MKEY245                          \ Master key bit 245 (i = 31 to 0)
$00400000 constant MCE1_MCE_MKEYR7_MKEY246                          \ Master key bit 246 (i = 31 to 0)
$00800000 constant MCE1_MCE_MKEYR7_MKEY247                          \ Master key bit 247 (i = 31 to 0)
$01000000 constant MCE1_MCE_MKEYR7_MKEY248                          \ Master key bit 248 (i = 31 to 0)
$02000000 constant MCE1_MCE_MKEYR7_MKEY249                          \ Master key bit 249 (i = 31 to 0)
$04000000 constant MCE1_MCE_MKEYR7_MKEY250                          \ Master key bit 250 (i = 31 to 0)
$08000000 constant MCE1_MCE_MKEYR7_MKEY251                          \ Master key bit 251 (i = 31 to 0)
$10000000 constant MCE1_MCE_MKEYR7_MKEY252                          \ Master key bit 252 (i = 31 to 0)
$20000000 constant MCE1_MCE_MKEYR7_MKEY253                          \ Master key bit 253 (i = 31 to 0)
$40000000 constant MCE1_MCE_MKEYR7_MKEY254                          \ Master key bit 254 (i = 31 to 0)
$80000000 constant MCE1_MCE_MKEYR7_MKEY255                          \ Master key bit 255 (i = 31 to 0)


\
\ @brief MCE fast master key 0
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$00000001 constant MCE1_MCE_FMKEYR0_FMKEY0                          \ Fast master key bit 0 (i = 31 to 0)
$00000002 constant MCE1_MCE_FMKEYR0_FMKEY1                          \ Fast master key bit 1 (i = 31 to 0)
$00000004 constant MCE1_MCE_FMKEYR0_FMKEY2                          \ Fast master key bit 2 (i = 31 to 0)
$00000008 constant MCE1_MCE_FMKEYR0_FMKEY3                          \ Fast master key bit 3 (i = 31 to 0)
$00000010 constant MCE1_MCE_FMKEYR0_FMKEY4                          \ Fast master key bit 4 (i = 31 to 0)
$00000020 constant MCE1_MCE_FMKEYR0_FMKEY5                          \ Fast master key bit 5 (i = 31 to 0)
$00000040 constant MCE1_MCE_FMKEYR0_FMKEY6                          \ Fast master key bit 6 (i = 31 to 0)
$00000080 constant MCE1_MCE_FMKEYR0_FMKEY7                          \ Fast master key bit 7 (i = 31 to 0)
$00000100 constant MCE1_MCE_FMKEYR0_FMKEY8                          \ Fast master key bit 8 (i = 31 to 0)
$00000200 constant MCE1_MCE_FMKEYR0_FMKEY9                          \ Fast master key bit 9 (i = 31 to 0)
$00000400 constant MCE1_MCE_FMKEYR0_FMKEY10                         \ Fast master key bit 10 (i = 31 to 0)
$00000800 constant MCE1_MCE_FMKEYR0_FMKEY11                         \ Fast master key bit 11 (i = 31 to 0)
$00001000 constant MCE1_MCE_FMKEYR0_FMKEY12                         \ Fast master key bit 12 (i = 31 to 0)
$00002000 constant MCE1_MCE_FMKEYR0_FMKEY13                         \ Fast master key bit 13 (i = 31 to 0)
$00004000 constant MCE1_MCE_FMKEYR0_FMKEY14                         \ Fast master key bit 14 (i = 31 to 0)
$00008000 constant MCE1_MCE_FMKEYR0_FMKEY15                         \ Fast master key bit 15 (i = 31 to 0)
$00010000 constant MCE1_MCE_FMKEYR0_FMKEY16                         \ Fast master key bit 16 (i = 31 to 0)
$00020000 constant MCE1_MCE_FMKEYR0_FMKEY17                         \ Fast master key bit 17 (i = 31 to 0)
$00040000 constant MCE1_MCE_FMKEYR0_FMKEY18                         \ Fast master key bit 18 (i = 31 to 0)
$00080000 constant MCE1_MCE_FMKEYR0_FMKEY19                         \ Fast master key bit 19 (i = 31 to 0)
$00100000 constant MCE1_MCE_FMKEYR0_FMKEY20                         \ Fast master key bit 20 (i = 31 to 0)
$00200000 constant MCE1_MCE_FMKEYR0_FMKEY21                         \ Fast master key bit 21 (i = 31 to 0)
$00400000 constant MCE1_MCE_FMKEYR0_FMKEY22                         \ Fast master key bit 22 (i = 31 to 0)
$00800000 constant MCE1_MCE_FMKEYR0_FMKEY23                         \ Fast master key bit 23 (i = 31 to 0)
$01000000 constant MCE1_MCE_FMKEYR0_FMKEY24                         \ Fast master key bit 24 (i = 31 to 0)
$02000000 constant MCE1_MCE_FMKEYR0_FMKEY25                         \ Fast master key bit 25 (i = 31 to 0)
$04000000 constant MCE1_MCE_FMKEYR0_FMKEY26                         \ Fast master key bit 26 (i = 31 to 0)
$08000000 constant MCE1_MCE_FMKEYR0_FMKEY27                         \ Fast master key bit 27 (i = 31 to 0)
$10000000 constant MCE1_MCE_FMKEYR0_FMKEY28                         \ Fast master key bit 28 (i = 31 to 0)
$20000000 constant MCE1_MCE_FMKEYR0_FMKEY29                         \ Fast master key bit 29 (i = 31 to 0)
$40000000 constant MCE1_MCE_FMKEYR0_FMKEY30                         \ Fast master key bit 30 (i = 31 to 0)
$80000000 constant MCE1_MCE_FMKEYR0_FMKEY31                         \ Fast master key bit 31 (i = 31 to 0)


\
\ @brief MCE fast master key 1
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$00000001 constant MCE1_MCE_FMKEYR1_FMKEY32                         \ Fast master key bit 32 (i = 31 to 0)
$00000002 constant MCE1_MCE_FMKEYR1_FMKEY33                         \ Fast master key bit 33 (i = 31 to 0)
$00000004 constant MCE1_MCE_FMKEYR1_FMKEY34                         \ Fast master key bit 34 (i = 31 to 0)
$00000008 constant MCE1_MCE_FMKEYR1_FMKEY35                         \ Fast master key bit 35 (i = 31 to 0)
$00000010 constant MCE1_MCE_FMKEYR1_FMKEY36                         \ Fast master key bit 36 (i = 31 to 0)
$00000020 constant MCE1_MCE_FMKEYR1_FMKEY37                         \ Fast master key bit 37 (i = 31 to 0)
$00000040 constant MCE1_MCE_FMKEYR1_FMKEY38                         \ Fast master key bit 38 (i = 31 to 0)
$00000080 constant MCE1_MCE_FMKEYR1_FMKEY39                         \ Fast master key bit 39 (i = 31 to 0)
$00000100 constant MCE1_MCE_FMKEYR1_FMKEY40                         \ Fast master key bit 40 (i = 31 to 0)
$00000200 constant MCE1_MCE_FMKEYR1_FMKEY41                         \ Fast master key bit 41 (i = 31 to 0)
$00000400 constant MCE1_MCE_FMKEYR1_FMKEY42                         \ Fast master key bit 42 (i = 31 to 0)
$00000800 constant MCE1_MCE_FMKEYR1_FMKEY43                         \ Fast master key bit 43 (i = 31 to 0)
$00001000 constant MCE1_MCE_FMKEYR1_FMKEY44                         \ Fast master key bit 44 (i = 31 to 0)
$00002000 constant MCE1_MCE_FMKEYR1_FMKEY45                         \ Fast master key bit 45 (i = 31 to 0)
$00004000 constant MCE1_MCE_FMKEYR1_FMKEY46                         \ Fast master key bit 46 (i = 31 to 0)
$00008000 constant MCE1_MCE_FMKEYR1_FMKEY47                         \ Fast master key bit 47 (i = 31 to 0)
$00010000 constant MCE1_MCE_FMKEYR1_FMKEY48                         \ Fast master key bit 48 (i = 31 to 0)
$00020000 constant MCE1_MCE_FMKEYR1_FMKEY49                         \ Fast master key bit 49 (i = 31 to 0)
$00040000 constant MCE1_MCE_FMKEYR1_FMKEY50                         \ Fast master key bit 50 (i = 31 to 0)
$00080000 constant MCE1_MCE_FMKEYR1_FMKEY51                         \ Fast master key bit 51 (i = 31 to 0)
$00100000 constant MCE1_MCE_FMKEYR1_FMKEY52                         \ Fast master key bit 52 (i = 31 to 0)
$00200000 constant MCE1_MCE_FMKEYR1_FMKEY53                         \ Fast master key bit 53 (i = 31 to 0)
$00400000 constant MCE1_MCE_FMKEYR1_FMKEY54                         \ Fast master key bit 54 (i = 31 to 0)
$00800000 constant MCE1_MCE_FMKEYR1_FMKEY55                         \ Fast master key bit 55 (i = 31 to 0)
$01000000 constant MCE1_MCE_FMKEYR1_FMKEY56                         \ Fast master key bit 56 (i = 31 to 0)
$02000000 constant MCE1_MCE_FMKEYR1_FMKEY57                         \ Fast master key bit 57 (i = 31 to 0)
$04000000 constant MCE1_MCE_FMKEYR1_FMKEY58                         \ Fast master key bit 58 (i = 31 to 0)
$08000000 constant MCE1_MCE_FMKEYR1_FMKEY59                         \ Fast master key bit 59 (i = 31 to 0)
$10000000 constant MCE1_MCE_FMKEYR1_FMKEY60                         \ Fast master key bit 60 (i = 31 to 0)
$20000000 constant MCE1_MCE_FMKEYR1_FMKEY61                         \ Fast master key bit 61 (i = 31 to 0)
$40000000 constant MCE1_MCE_FMKEYR1_FMKEY62                         \ Fast master key bit 62 (i = 31 to 0)
$80000000 constant MCE1_MCE_FMKEYR1_FMKEY63                         \ Fast master key bit 63 (i = 31 to 0)


\
\ @brief MCE fast master key 2
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$00000001 constant MCE1_MCE_FMKEYR2_FMKEY64                         \ Fast master key bit 64 (i = 31 to 0)
$00000002 constant MCE1_MCE_FMKEYR2_FMKEY65                         \ Fast master key bit 65 (i = 31 to 0)
$00000004 constant MCE1_MCE_FMKEYR2_FMKEY66                         \ Fast master key bit 66 (i = 31 to 0)
$00000008 constant MCE1_MCE_FMKEYR2_FMKEY67                         \ Fast master key bit 67 (i = 31 to 0)
$00000010 constant MCE1_MCE_FMKEYR2_FMKEY68                         \ Fast master key bit 68 (i = 31 to 0)
$00000020 constant MCE1_MCE_FMKEYR2_FMKEY69                         \ Fast master key bit 69 (i = 31 to 0)
$00000040 constant MCE1_MCE_FMKEYR2_FMKEY70                         \ Fast master key bit 70 (i = 31 to 0)
$00000080 constant MCE1_MCE_FMKEYR2_FMKEY71                         \ Fast master key bit 71 (i = 31 to 0)
$00000100 constant MCE1_MCE_FMKEYR2_FMKEY72                         \ Fast master key bit 72 (i = 31 to 0)
$00000200 constant MCE1_MCE_FMKEYR2_FMKEY73                         \ Fast master key bit 73 (i = 31 to 0)
$00000400 constant MCE1_MCE_FMKEYR2_FMKEY74                         \ Fast master key bit 74 (i = 31 to 0)
$00000800 constant MCE1_MCE_FMKEYR2_FMKEY75                         \ Fast master key bit 75 (i = 31 to 0)
$00001000 constant MCE1_MCE_FMKEYR2_FMKEY76                         \ Fast master key bit 76 (i = 31 to 0)
$00002000 constant MCE1_MCE_FMKEYR2_FMKEY77                         \ Fast master key bit 77 (i = 31 to 0)
$00004000 constant MCE1_MCE_FMKEYR2_FMKEY78                         \ Fast master key bit 78 (i = 31 to 0)
$00008000 constant MCE1_MCE_FMKEYR2_FMKEY79                         \ Fast master key bit 79 (i = 31 to 0)
$00010000 constant MCE1_MCE_FMKEYR2_FMKEY80                         \ Fast master key bit 80 (i = 31 to 0)
$00020000 constant MCE1_MCE_FMKEYR2_FMKEY81                         \ Fast master key bit 81 (i = 31 to 0)
$00040000 constant MCE1_MCE_FMKEYR2_FMKEY82                         \ Fast master key bit 82 (i = 31 to 0)
$00080000 constant MCE1_MCE_FMKEYR2_FMKEY83                         \ Fast master key bit 83 (i = 31 to 0)
$00100000 constant MCE1_MCE_FMKEYR2_FMKEY84                         \ Fast master key bit 84 (i = 31 to 0)
$00200000 constant MCE1_MCE_FMKEYR2_FMKEY85                         \ Fast master key bit 85 (i = 31 to 0)
$00400000 constant MCE1_MCE_FMKEYR2_FMKEY86                         \ Fast master key bit 86 (i = 31 to 0)
$00800000 constant MCE1_MCE_FMKEYR2_FMKEY87                         \ Fast master key bit 87 (i = 31 to 0)
$01000000 constant MCE1_MCE_FMKEYR2_FMKEY88                         \ Fast master key bit 88 (i = 31 to 0)
$02000000 constant MCE1_MCE_FMKEYR2_FMKEY89                         \ Fast master key bit 89 (i = 31 to 0)
$04000000 constant MCE1_MCE_FMKEYR2_FMKEY90                         \ Fast master key bit 90 (i = 31 to 0)
$08000000 constant MCE1_MCE_FMKEYR2_FMKEY91                         \ Fast master key bit 91 (i = 31 to 0)
$10000000 constant MCE1_MCE_FMKEYR2_FMKEY92                         \ Fast master key bit 92 (i = 31 to 0)
$20000000 constant MCE1_MCE_FMKEYR2_FMKEY93                         \ Fast master key bit 93 (i = 31 to 0)
$40000000 constant MCE1_MCE_FMKEYR2_FMKEY94                         \ Fast master key bit 94 (i = 31 to 0)
$80000000 constant MCE1_MCE_FMKEYR2_FMKEY95                         \ Fast master key bit 95 (i = 31 to 0)


\
\ @brief MCE fast master key 3
\ Address offset: 0x22C
\ Reset value: 0x00000000
\

$00000001 constant MCE1_MCE_FMKEYR3_FMKEY96                         \ Fast master key bit 96 (i = 31 to 0)
$00000002 constant MCE1_MCE_FMKEYR3_FMKEY97                         \ Fast master key bit 97 (i = 31 to 0)
$00000004 constant MCE1_MCE_FMKEYR3_FMKEY98                         \ Fast master key bit 98 (i = 31 to 0)
$00000008 constant MCE1_MCE_FMKEYR3_FMKEY99                         \ Fast master key bit 99 (i = 31 to 0)
$00000010 constant MCE1_MCE_FMKEYR3_FMKEY100                        \ Fast master key bit 100 (i = 31 to 0)
$00000020 constant MCE1_MCE_FMKEYR3_FMKEY101                        \ Fast master key bit 101 (i = 31 to 0)
$00000040 constant MCE1_MCE_FMKEYR3_FMKEY102                        \ Fast master key bit 102 (i = 31 to 0)
$00000080 constant MCE1_MCE_FMKEYR3_FMKEY103                        \ Fast master key bit 103 (i = 31 to 0)
$00000100 constant MCE1_MCE_FMKEYR3_FMKEY104                        \ Fast master key bit 104 (i = 31 to 0)
$00000200 constant MCE1_MCE_FMKEYR3_FMKEY105                        \ Fast master key bit 105 (i = 31 to 0)
$00000400 constant MCE1_MCE_FMKEYR3_FMKEY106                        \ Fast master key bit 106 (i = 31 to 0)
$00000800 constant MCE1_MCE_FMKEYR3_FMKEY107                        \ Fast master key bit 107 (i = 31 to 0)
$00001000 constant MCE1_MCE_FMKEYR3_FMKEY108                        \ Fast master key bit 108 (i = 31 to 0)
$00002000 constant MCE1_MCE_FMKEYR3_FMKEY109                        \ Fast master key bit 109 (i = 31 to 0)
$00004000 constant MCE1_MCE_FMKEYR3_FMKEY110                        \ Fast master key bit 110 (i = 31 to 0)
$00008000 constant MCE1_MCE_FMKEYR3_FMKEY111                        \ Fast master key bit 111 (i = 31 to 0)
$00010000 constant MCE1_MCE_FMKEYR3_FMKEY112                        \ Fast master key bit 112 (i = 31 to 0)
$00020000 constant MCE1_MCE_FMKEYR3_FMKEY113                        \ Fast master key bit 113 (i = 31 to 0)
$00040000 constant MCE1_MCE_FMKEYR3_FMKEY114                        \ Fast master key bit 114 (i = 31 to 0)
$00080000 constant MCE1_MCE_FMKEYR3_FMKEY115                        \ Fast master key bit 115 (i = 31 to 0)
$00100000 constant MCE1_MCE_FMKEYR3_FMKEY116                        \ Fast master key bit 116 (i = 31 to 0)
$00200000 constant MCE1_MCE_FMKEYR3_FMKEY117                        \ Fast master key bit 117 (i = 31 to 0)
$00400000 constant MCE1_MCE_FMKEYR3_FMKEY118                        \ Fast master key bit 118 (i = 31 to 0)
$00800000 constant MCE1_MCE_FMKEYR3_FMKEY119                        \ Fast master key bit 119 (i = 31 to 0)
$01000000 constant MCE1_MCE_FMKEYR3_FMKEY120                        \ Fast master key bit 120 (i = 31 to 0)
$02000000 constant MCE1_MCE_FMKEYR3_FMKEY121                        \ Fast master key bit 121 (i = 31 to 0)
$04000000 constant MCE1_MCE_FMKEYR3_FMKEY122                        \ Fast master key bit 122 (i = 31 to 0)
$08000000 constant MCE1_MCE_FMKEYR3_FMKEY123                        \ Fast master key bit 123 (i = 31 to 0)
$10000000 constant MCE1_MCE_FMKEYR3_FMKEY124                        \ Fast master key bit 124 (i = 31 to 0)
$20000000 constant MCE1_MCE_FMKEYR3_FMKEY125                        \ Fast master key bit 125 (i = 31 to 0)
$40000000 constant MCE1_MCE_FMKEYR3_FMKEY126                        \ Fast master key bit 126 (i = 31 to 0)
$80000000 constant MCE1_MCE_FMKEYR3_FMKEY127                        \ Fast master key bit 127 (i = 31 to 0)


\
\ @brief MCE fast master key 4
\ Address offset: 0x230
\ Reset value: 0x00000000
\

$00000001 constant MCE1_MCE_FMKEYR4_FMKEY128                        \ Fast master key bit 128 (i = 31 to 0)
$00000002 constant MCE1_MCE_FMKEYR4_FMKEY129                        \ Fast master key bit 129 (i = 31 to 0)
$00000004 constant MCE1_MCE_FMKEYR4_FMKEY130                        \ Fast master key bit 130 (i = 31 to 0)
$00000008 constant MCE1_MCE_FMKEYR4_FMKEY131                        \ Fast master key bit 131 (i = 31 to 0)
$00000010 constant MCE1_MCE_FMKEYR4_FMKEY132                        \ Fast master key bit 132 (i = 31 to 0)
$00000020 constant MCE1_MCE_FMKEYR4_FMKEY133                        \ Fast master key bit 133 (i = 31 to 0)
$00000040 constant MCE1_MCE_FMKEYR4_FMKEY134                        \ Fast master key bit 134 (i = 31 to 0)
$00000080 constant MCE1_MCE_FMKEYR4_FMKEY135                        \ Fast master key bit 135 (i = 31 to 0)
$00000100 constant MCE1_MCE_FMKEYR4_FMKEY136                        \ Fast master key bit 136 (i = 31 to 0)
$00000200 constant MCE1_MCE_FMKEYR4_FMKEY137                        \ Fast master key bit 137 (i = 31 to 0)
$00000400 constant MCE1_MCE_FMKEYR4_FMKEY138                        \ Fast master key bit 138 (i = 31 to 0)
$00000800 constant MCE1_MCE_FMKEYR4_FMKEY139                        \ Fast master key bit 139 (i = 31 to 0)
$00001000 constant MCE1_MCE_FMKEYR4_FMKEY140                        \ Fast master key bit 140 (i = 31 to 0)
$00002000 constant MCE1_MCE_FMKEYR4_FMKEY141                        \ Fast master key bit 141 (i = 31 to 0)
$00004000 constant MCE1_MCE_FMKEYR4_FMKEY142                        \ Fast master key bit 142 (i = 31 to 0)
$00008000 constant MCE1_MCE_FMKEYR4_FMKEY143                        \ Fast master key bit 143 (i = 31 to 0)
$00010000 constant MCE1_MCE_FMKEYR4_FMKEY144                        \ Fast master key bit 144 (i = 31 to 0)
$00020000 constant MCE1_MCE_FMKEYR4_FMKEY145                        \ Fast master key bit 145 (i = 31 to 0)
$00040000 constant MCE1_MCE_FMKEYR4_FMKEY146                        \ Fast master key bit 146 (i = 31 to 0)
$00080000 constant MCE1_MCE_FMKEYR4_FMKEY147                        \ Fast master key bit 147 (i = 31 to 0)
$00100000 constant MCE1_MCE_FMKEYR4_FMKEY148                        \ Fast master key bit 148 (i = 31 to 0)
$00200000 constant MCE1_MCE_FMKEYR4_FMKEY149                        \ Fast master key bit 149 (i = 31 to 0)
$00400000 constant MCE1_MCE_FMKEYR4_FMKEY150                        \ Fast master key bit 150 (i = 31 to 0)
$00800000 constant MCE1_MCE_FMKEYR4_FMKEY151                        \ Fast master key bit 151 (i = 31 to 0)
$01000000 constant MCE1_MCE_FMKEYR4_FMKEY152                        \ Fast master key bit 152 (i = 31 to 0)
$02000000 constant MCE1_MCE_FMKEYR4_FMKEY153                        \ Fast master key bit 153 (i = 31 to 0)
$04000000 constant MCE1_MCE_FMKEYR4_FMKEY154                        \ Fast master key bit 154 (i = 31 to 0)
$08000000 constant MCE1_MCE_FMKEYR4_FMKEY155                        \ Fast master key bit 155 (i = 31 to 0)
$10000000 constant MCE1_MCE_FMKEYR4_FMKEY156                        \ Fast master key bit 156 (i = 31 to 0)
$20000000 constant MCE1_MCE_FMKEYR4_FMKEY157                        \ Fast master key bit 157 (i = 31 to 0)
$40000000 constant MCE1_MCE_FMKEYR4_FMKEY158                        \ Fast master key bit 158 (i = 31 to 0)
$80000000 constant MCE1_MCE_FMKEYR4_FMKEY159                        \ Fast master key bit 159 (i = 31 to 0)


\
\ @brief MCE fast master key 5
\ Address offset: 0x234
\ Reset value: 0x00000000
\

$00000001 constant MCE1_MCE_FMKEYR5_FMKEY160                        \ Fast master key bit 160 (i = 31 to 0)
$00000002 constant MCE1_MCE_FMKEYR5_FMKEY161                        \ Fast master key bit 161 (i = 31 to 0)
$00000004 constant MCE1_MCE_FMKEYR5_FMKEY162                        \ Fast master key bit 162 (i = 31 to 0)
$00000008 constant MCE1_MCE_FMKEYR5_FMKEY163                        \ Fast master key bit 163 (i = 31 to 0)
$00000010 constant MCE1_MCE_FMKEYR5_FMKEY164                        \ Fast master key bit 164 (i = 31 to 0)
$00000020 constant MCE1_MCE_FMKEYR5_FMKEY165                        \ Fast master key bit 165 (i = 31 to 0)
$00000040 constant MCE1_MCE_FMKEYR5_FMKEY166                        \ Fast master key bit 166 (i = 31 to 0)
$00000080 constant MCE1_MCE_FMKEYR5_FMKEY167                        \ Fast master key bit 167 (i = 31 to 0)
$00000100 constant MCE1_MCE_FMKEYR5_FMKEY168                        \ Fast master key bit 168 (i = 31 to 0)
$00000200 constant MCE1_MCE_FMKEYR5_FMKEY169                        \ Fast master key bit 169 (i = 31 to 0)
$00000400 constant MCE1_MCE_FMKEYR5_FMKEY170                        \ Fast master key bit 170 (i = 31 to 0)
$00000800 constant MCE1_MCE_FMKEYR5_FMKEY171                        \ Fast master key bit 171 (i = 31 to 0)
$00001000 constant MCE1_MCE_FMKEYR5_FMKEY172                        \ Fast master key bit 172 (i = 31 to 0)
$00002000 constant MCE1_MCE_FMKEYR5_FMKEY173                        \ Fast master key bit 173 (i = 31 to 0)
$00004000 constant MCE1_MCE_FMKEYR5_FMKEY174                        \ Fast master key bit 174 (i = 31 to 0)
$00008000 constant MCE1_MCE_FMKEYR5_FMKEY175                        \ Fast master key bit 175 (i = 31 to 0)
$00010000 constant MCE1_MCE_FMKEYR5_FMKEY176                        \ Fast master key bit 176 (i = 31 to 0)
$00020000 constant MCE1_MCE_FMKEYR5_FMKEY177                        \ Fast master key bit 177 (i = 31 to 0)
$00040000 constant MCE1_MCE_FMKEYR5_FMKEY178                        \ Fast master key bit 178 (i = 31 to 0)
$00080000 constant MCE1_MCE_FMKEYR5_FMKEY179                        \ Fast master key bit 179 (i = 31 to 0)
$00100000 constant MCE1_MCE_FMKEYR5_FMKEY180                        \ Fast master key bit 180 (i = 31 to 0)
$00200000 constant MCE1_MCE_FMKEYR5_FMKEY181                        \ Fast master key bit 181 (i = 31 to 0)
$00400000 constant MCE1_MCE_FMKEYR5_FMKEY182                        \ Fast master key bit 182 (i = 31 to 0)
$00800000 constant MCE1_MCE_FMKEYR5_FMKEY183                        \ Fast master key bit 183 (i = 31 to 0)
$01000000 constant MCE1_MCE_FMKEYR5_FMKEY184                        \ Fast master key bit 184 (i = 31 to 0)
$02000000 constant MCE1_MCE_FMKEYR5_FMKEY185                        \ Fast master key bit 185 (i = 31 to 0)
$04000000 constant MCE1_MCE_FMKEYR5_FMKEY186                        \ Fast master key bit 186 (i = 31 to 0)
$08000000 constant MCE1_MCE_FMKEYR5_FMKEY187                        \ Fast master key bit 187 (i = 31 to 0)
$10000000 constant MCE1_MCE_FMKEYR5_FMKEY188                        \ Fast master key bit 188 (i = 31 to 0)
$20000000 constant MCE1_MCE_FMKEYR5_FMKEY189                        \ Fast master key bit 189 (i = 31 to 0)
$40000000 constant MCE1_MCE_FMKEYR5_FMKEY190                        \ Fast master key bit 190 (i = 31 to 0)
$80000000 constant MCE1_MCE_FMKEYR5_FMKEY191                        \ Fast master key bit 191 (i = 31 to 0)


\
\ @brief MCE fast master key 6
\ Address offset: 0x238
\ Reset value: 0x00000000
\

$00000001 constant MCE1_MCE_FMKEYR6_FMKEY192                        \ Fast master key bit 192 (i = 31 to 0)
$00000002 constant MCE1_MCE_FMKEYR6_FMKEY193                        \ Fast master key bit 193 (i = 31 to 0)
$00000004 constant MCE1_MCE_FMKEYR6_FMKEY194                        \ Fast master key bit 194 (i = 31 to 0)
$00000008 constant MCE1_MCE_FMKEYR6_FMKEY195                        \ Fast master key bit 195 (i = 31 to 0)
$00000010 constant MCE1_MCE_FMKEYR6_FMKEY196                        \ Fast master key bit 196 (i = 31 to 0)
$00000020 constant MCE1_MCE_FMKEYR6_FMKEY197                        \ Fast master key bit 197 (i = 31 to 0)
$00000040 constant MCE1_MCE_FMKEYR6_FMKEY198                        \ Fast master key bit 198 (i = 31 to 0)
$00000080 constant MCE1_MCE_FMKEYR6_FMKEY199                        \ Fast master key bit 199 (i = 31 to 0)
$00000100 constant MCE1_MCE_FMKEYR6_FMKEY200                        \ Fast master key bit 200 (i = 31 to 0)
$00000200 constant MCE1_MCE_FMKEYR6_FMKEY201                        \ Fast master key bit 201 (i = 31 to 0)
$00000400 constant MCE1_MCE_FMKEYR6_FMKEY202                        \ Fast master key bit 202 (i = 31 to 0)
$00000800 constant MCE1_MCE_FMKEYR6_FMKEY203                        \ Fast master key bit 203 (i = 31 to 0)
$00001000 constant MCE1_MCE_FMKEYR6_FMKEY204                        \ Fast master key bit 204 (i = 31 to 0)
$00002000 constant MCE1_MCE_FMKEYR6_FMKEY205                        \ Fast master key bit 205 (i = 31 to 0)
$00004000 constant MCE1_MCE_FMKEYR6_FMKEY206                        \ Fast master key bit 206 (i = 31 to 0)
$00008000 constant MCE1_MCE_FMKEYR6_FMKEY207                        \ Fast master key bit 207 (i = 31 to 0)
$00010000 constant MCE1_MCE_FMKEYR6_FMKEY208                        \ Fast master key bit 208 (i = 31 to 0)
$00020000 constant MCE1_MCE_FMKEYR6_FMKEY209                        \ Fast master key bit 209 (i = 31 to 0)
$00040000 constant MCE1_MCE_FMKEYR6_FMKEY210                        \ Fast master key bit 210 (i = 31 to 0)
$00080000 constant MCE1_MCE_FMKEYR6_FMKEY211                        \ Fast master key bit 211 (i = 31 to 0)
$00100000 constant MCE1_MCE_FMKEYR6_FMKEY212                        \ Fast master key bit 212 (i = 31 to 0)
$00200000 constant MCE1_MCE_FMKEYR6_FMKEY213                        \ Fast master key bit 213 (i = 31 to 0)
$00400000 constant MCE1_MCE_FMKEYR6_FMKEY214                        \ Fast master key bit 214 (i = 31 to 0)
$00800000 constant MCE1_MCE_FMKEYR6_FMKEY215                        \ Fast master key bit 215 (i = 31 to 0)
$01000000 constant MCE1_MCE_FMKEYR6_FMKEY216                        \ Fast master key bit 216 (i = 31 to 0)
$02000000 constant MCE1_MCE_FMKEYR6_FMKEY217                        \ Fast master key bit 217 (i = 31 to 0)
$04000000 constant MCE1_MCE_FMKEYR6_FMKEY218                        \ Fast master key bit 218 (i = 31 to 0)
$08000000 constant MCE1_MCE_FMKEYR6_FMKEY219                        \ Fast master key bit 219 (i = 31 to 0)
$10000000 constant MCE1_MCE_FMKEYR6_FMKEY220                        \ Fast master key bit 220 (i = 31 to 0)
$20000000 constant MCE1_MCE_FMKEYR6_FMKEY221                        \ Fast master key bit 221 (i = 31 to 0)
$40000000 constant MCE1_MCE_FMKEYR6_FMKEY222                        \ Fast master key bit 222 (i = 31 to 0)
$80000000 constant MCE1_MCE_FMKEYR6_FMKEY223                        \ Fast master key bit 223 (i = 31 to 0)


\
\ @brief MCE fast master key 7
\ Address offset: 0x23C
\ Reset value: 0x00000000
\

$00000001 constant MCE1_MCE_FMKEYR7_FMKEY224                        \ Fast master key bit 224 (i = 31 to 0)
$00000002 constant MCE1_MCE_FMKEYR7_FMKEY225                        \ Fast master key bit 225 (i = 31 to 0)
$00000004 constant MCE1_MCE_FMKEYR7_FMKEY226                        \ Fast master key bit 226 (i = 31 to 0)
$00000008 constant MCE1_MCE_FMKEYR7_FMKEY227                        \ Fast master key bit 227 (i = 31 to 0)
$00000010 constant MCE1_MCE_FMKEYR7_FMKEY228                        \ Fast master key bit 228 (i = 31 to 0)
$00000020 constant MCE1_MCE_FMKEYR7_FMKEY229                        \ Fast master key bit 229 (i = 31 to 0)
$00000040 constant MCE1_MCE_FMKEYR7_FMKEY230                        \ Fast master key bit 230 (i = 31 to 0)
$00000080 constant MCE1_MCE_FMKEYR7_FMKEY231                        \ Fast master key bit 231 (i = 31 to 0)
$00000100 constant MCE1_MCE_FMKEYR7_FMKEY232                        \ Fast master key bit 232 (i = 31 to 0)
$00000200 constant MCE1_MCE_FMKEYR7_FMKEY233                        \ Fast master key bit 233 (i = 31 to 0)
$00000400 constant MCE1_MCE_FMKEYR7_FMKEY234                        \ Fast master key bit 234 (i = 31 to 0)
$00000800 constant MCE1_MCE_FMKEYR7_FMKEY235                        \ Fast master key bit 235 (i = 31 to 0)
$00001000 constant MCE1_MCE_FMKEYR7_FMKEY236                        \ Fast master key bit 236 (i = 31 to 0)
$00002000 constant MCE1_MCE_FMKEYR7_FMKEY237                        \ Fast master key bit 237 (i = 31 to 0)
$00004000 constant MCE1_MCE_FMKEYR7_FMKEY238                        \ Fast master key bit 238 (i = 31 to 0)
$00008000 constant MCE1_MCE_FMKEYR7_FMKEY239                        \ Fast master key bit 239 (i = 31 to 0)
$00010000 constant MCE1_MCE_FMKEYR7_FMKEY240                        \ Fast master key bit 240 (i = 31 to 0)
$00020000 constant MCE1_MCE_FMKEYR7_FMKEY241                        \ Fast master key bit 241 (i = 31 to 0)
$00040000 constant MCE1_MCE_FMKEYR7_FMKEY242                        \ Fast master key bit 242 (i = 31 to 0)
$00080000 constant MCE1_MCE_FMKEYR7_FMKEY243                        \ Fast master key bit 243 (i = 31 to 0)
$00100000 constant MCE1_MCE_FMKEYR7_FMKEY244                        \ Fast master key bit 244 (i = 31 to 0)
$00200000 constant MCE1_MCE_FMKEYR7_FMKEY245                        \ Fast master key bit 245 (i = 31 to 0)
$00400000 constant MCE1_MCE_FMKEYR7_FMKEY246                        \ Fast master key bit 246 (i = 31 to 0)
$00800000 constant MCE1_MCE_FMKEYR7_FMKEY247                        \ Fast master key bit 247 (i = 31 to 0)
$01000000 constant MCE1_MCE_FMKEYR7_FMKEY248                        \ Fast master key bit 248 (i = 31 to 0)
$02000000 constant MCE1_MCE_FMKEYR7_FMKEY249                        \ Fast master key bit 249 (i = 31 to 0)
$04000000 constant MCE1_MCE_FMKEYR7_FMKEY250                        \ Fast master key bit 250 (i = 31 to 0)
$08000000 constant MCE1_MCE_FMKEYR7_FMKEY251                        \ Fast master key bit 251 (i = 31 to 0)
$10000000 constant MCE1_MCE_FMKEYR7_FMKEY252                        \ Fast master key bit 252 (i = 31 to 0)
$20000000 constant MCE1_MCE_FMKEYR7_FMKEY253                        \ Fast master key bit 253 (i = 31 to 0)
$40000000 constant MCE1_MCE_FMKEYR7_FMKEY254                        \ Fast master key bit 254 (i = 31 to 0)
$80000000 constant MCE1_MCE_FMKEYR7_FMKEY255                        \ Fast master key bit 255 (i = 31 to 0)


\
\ @brief MCE cipher context 1 configuration register
\ Address offset: 0x240
\ Reset value: 0x00000000
\

$00000001 constant MCE1_MCE_CC1CFGR_CCEN                            \ Cipher context enable
$00000002 constant MCE1_MCE_CC1CFGR_CCLOCK                          \ Cipher context lock
$00000004 constant MCE1_MCE_CC1CFGR_KEYLOCK                         \ Key lock
$00000030 constant MCE1_MCE_CC1CFGR_MODE                            \ Authorized cipher mode
$0000ff00 constant MCE1_MCE_CC1CFGR_KEYCRC                          \ Key CRC
$ffff0000 constant MCE1_MCE_CC1CFGR_VERSION                         \ Version


\
\ @brief MCE cipher context 1 nonce register 0
\ Address offset: 0x244
\ Reset value: 0x00000000
\

$00000000 constant MCE1_MCE_CC1NR0_SCNONCE                          \ Stream cipher nonce, bits [31:0]


\
\ @brief MCE cipher context 1 nonce register 1
\ Address offset: 0x248
\ Reset value: 0x00000000
\

$00000000 constant MCE1_MCE_CC1NR1_SCNONCE                          \ Stream cipher nonce, bits [63:32]


\
\ @brief MCE cipher context 1 key register 0
\ Address offset: 0x24C
\ Reset value: 0x00000000
\

$00000000 constant MCE1_MCE_CC1KEYR0_KEY                            \ cipher key, bits [31:0]


\
\ @brief MCE cipher context 1 key register 1
\ Address offset: 0x250
\ Reset value: 0x00000000
\

$00000000 constant MCE1_MCE_CC1KEYR1_KEY                            \ cipher key, bits [63:32]


\
\ @brief MCE cipher context 1 key register 2
\ Address offset: 0x254
\ Reset value: 0x00000000
\

$00000000 constant MCE1_MCE_CC1KEYR2_KEY                            \ cipher key, bits [95:64]


\
\ @brief MCE cipher context 1 key register 3
\ Address offset: 0x258
\ Reset value: 0x00000000
\

$00000000 constant MCE1_MCE_CC1KEYR3_KEY                            \ cipher key, bits [127:96]


\
\ @brief MCE cipher context 2 configuration register
\ Address offset: 0x270
\ Reset value: 0x00000000
\

$00000001 constant MCE1_MCE_CC2CFGR_CCEN                            \ Cipher context enable
$00000002 constant MCE1_MCE_CC2CFGR_CCLOCK                          \ Cipher context lock
$00000004 constant MCE1_MCE_CC2CFGR_KEYLOCK                         \ Key lock
$00000030 constant MCE1_MCE_CC2CFGR_MODE                            \ Authorized cipher mode
$0000ff00 constant MCE1_MCE_CC2CFGR_KEYCRC                          \ Key CRC
$ffff0000 constant MCE1_MCE_CC2CFGR_VERSION                         \ Version


\
\ @brief MCE cipher context 2 nonce register 0
\ Address offset: 0x274
\ Reset value: 0x00000000
\

$00000000 constant MCE1_MCE_CC2NR0_SCNONCE                          \ Stream cipher nonce, bits [31:0]


\
\ @brief MCE cipher context 2 nonce register 1
\ Address offset: 0x278
\ Reset value: 0x00000000
\

$00000000 constant MCE1_MCE_CC2NR1_SCNONCE                          \ Stream cipher nonce, bits [63:32]


\
\ @brief MCE cipher context 2 key register 0
\ Address offset: 0x27C
\ Reset value: 0x00000000
\

$00000000 constant MCE1_MCE_CC2KEYR0_KEY                            \ cipher key, bits [31:0]


\
\ @brief MCE cipher context 2 key register 1
\ Address offset: 0x280
\ Reset value: 0x00000000
\

$00000000 constant MCE1_MCE_CC2KEYR1_KEY                            \ cipher key, bits [63:32]


\
\ @brief MCE cipher context 2 key register 2
\ Address offset: 0x284
\ Reset value: 0x00000000
\

$00000000 constant MCE1_MCE_CC2KEYR2_KEY                            \ cipher key, bits [95:64]


\
\ @brief MCE cipher context 2 key register 3
\ Address offset: 0x288
\ Reset value: 0x00000000
\

$00000000 constant MCE1_MCE_CC2KEYR3_KEY                            \ cipher key, bits [127:96]


\
\ @brief Memory cipher engine
\
$4802b800 constant MCE1_MCE_CR    \ offset: 0x00 : MCE configuration register
$4802b804 constant MCE1_MCE_SR    \ offset: 0x04 : MCE status register
$4802b808 constant MCE1_MCE_IASR  \ offset: 0x08 : MCE illegal access status register
$4802b80c constant MCE1_MCE_IACR  \ offset: 0x0C : MCE illegal access clear register
$4802b810 constant MCE1_MCE_IAIER  \ offset: 0x10 : MCE illegal access interrupt enable register
$4802b824 constant MCE1_MCE_IADDR  \ offset: 0x24 : MCE illegal address register
$4802b840 constant MCE1_MCE_REGCR1  \ offset: 0x40 : MCE region 1 configuration register
$4802b844 constant MCE1_MCE_SADDR1  \ offset: 0x44 : MCE start address for region 1 register
$4802b848 constant MCE1_MCE_EADDR1  \ offset: 0x48 : MCE end address for region 1 register
$4802b850 constant MCE1_MCE_REGCR2  \ offset: 0x50 : MCE region 2 configuration register
$4802b854 constant MCE1_MCE_SADDR2  \ offset: 0x54 : MCE start address for region 2 register
$4802b858 constant MCE1_MCE_EADDR2  \ offset: 0x58 : MCE end address for region 2 register
$4802b860 constant MCE1_MCE_REGCR3  \ offset: 0x60 : MCE region 3 configuration register
$4802b864 constant MCE1_MCE_SADDR3  \ offset: 0x64 : MCE start address for region 3 register
$4802b868 constant MCE1_MCE_EADDR3  \ offset: 0x68 : MCE end address for region 3 register
$4802b870 constant MCE1_MCE_REGCR4  \ offset: 0x70 : MCE region 4 configuration register
$4802b874 constant MCE1_MCE_SADDR4  \ offset: 0x74 : MCE start address for region 4 register
$4802b878 constant MCE1_MCE_EADDR4  \ offset: 0x78 : MCE end address for region 4 register
$4802ba00 constant MCE1_MCE_MKEYR0  \ offset: 0x200 : .MCE master key 0
$4802ba04 constant MCE1_MCE_MKEYR1  \ offset: 0x204 : .MCE master key 1
$4802ba08 constant MCE1_MCE_MKEYR2  \ offset: 0x208 : .MCE master key 2
$4802ba0c constant MCE1_MCE_MKEYR3  \ offset: 0x20C : .MCE master key 3
$4802ba10 constant MCE1_MCE_MKEYR4  \ offset: 0x210 : .MCE master key 4
$4802ba14 constant MCE1_MCE_MKEYR5  \ offset: 0x214 : .MCE master key 5
$4802ba18 constant MCE1_MCE_MKEYR6  \ offset: 0x218 : .MCE master key 6
$4802ba1c constant MCE1_MCE_MKEYR7  \ offset: 0x21C : .MCE master key 7
$4802ba20 constant MCE1_MCE_FMKEYR0  \ offset: 0x220 : MCE fast master key 0
$4802ba24 constant MCE1_MCE_FMKEYR1  \ offset: 0x224 : MCE fast master key 1
$4802ba28 constant MCE1_MCE_FMKEYR2  \ offset: 0x228 : MCE fast master key 2
$4802ba2c constant MCE1_MCE_FMKEYR3  \ offset: 0x22C : MCE fast master key 3
$4802ba30 constant MCE1_MCE_FMKEYR4  \ offset: 0x230 : MCE fast master key 4
$4802ba34 constant MCE1_MCE_FMKEYR5  \ offset: 0x234 : MCE fast master key 5
$4802ba38 constant MCE1_MCE_FMKEYR6  \ offset: 0x238 : MCE fast master key 6
$4802ba3c constant MCE1_MCE_FMKEYR7  \ offset: 0x23C : MCE fast master key 7
$4802ba40 constant MCE1_MCE_CC1CFGR  \ offset: 0x240 : MCE cipher context 1 configuration register
$4802ba44 constant MCE1_MCE_CC1NR0  \ offset: 0x244 : MCE cipher context 1 nonce register 0
$4802ba48 constant MCE1_MCE_CC1NR1  \ offset: 0x248 : MCE cipher context 1 nonce register 1
$4802ba4c constant MCE1_MCE_CC1KEYR0  \ offset: 0x24C : MCE cipher context 1 key register 0
$4802ba50 constant MCE1_MCE_CC1KEYR1  \ offset: 0x250 : MCE cipher context 1 key register 1
$4802ba54 constant MCE1_MCE_CC1KEYR2  \ offset: 0x254 : MCE cipher context 1 key register 2
$4802ba58 constant MCE1_MCE_CC1KEYR3  \ offset: 0x258 : MCE cipher context 1 key register 3
$4802ba70 constant MCE1_MCE_CC2CFGR  \ offset: 0x270 : MCE cipher context 2 configuration register
$4802ba74 constant MCE1_MCE_CC2NR0  \ offset: 0x274 : MCE cipher context 2 nonce register 0
$4802ba78 constant MCE1_MCE_CC2NR1  \ offset: 0x278 : MCE cipher context 2 nonce register 1
$4802ba7c constant MCE1_MCE_CC2KEYR0  \ offset: 0x27C : MCE cipher context 2 key register 0
$4802ba80 constant MCE1_MCE_CC2KEYR1  \ offset: 0x280 : MCE cipher context 2 key register 1
$4802ba84 constant MCE1_MCE_CC2KEYR2  \ offset: 0x284 : MCE cipher context 2 key register 2
$4802ba88 constant MCE1_MCE_CC2KEYR3  \ offset: 0x288 : MCE cipher context 2 key register 3

