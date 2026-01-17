\
\ @file mce.fs
\ @brief Memory cipher engine
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] MCE_DEF

  [ifdef] MCE_MCE_CR_DEF
    \
    \ @brief MCE configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000010
    \
    $00 constant MCE_GLOCK                      \ [0x00] Global lock
    $01 constant MCE_MKLOCK                     \ [0x01] Master keys lock
    $04 constant MCE_CIPHERSEL                  \ [0x04 : 2] Cipher selection
  [then]


  [ifdef] MCE_MCE_SR_DEF
    \
    \ @brief MCE status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant MCE_MKVALID                    \ [0x00] Master key valid
    $02 constant MCE_FMKVALID                   \ [0x02] Fast master key valid
    $04 constant MCE_ENCDIS                     \ [0x04] encryption disabled
  [then]


  [ifdef] MCE_MCE_IASR_DEF
    \
    \ @brief MCE illegal access status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $01 constant MCE_IAEF                       \ [0x01] Illegal access error flag
  [then]


  [ifdef] MCE_MCE_IACR_DEF
    \
    \ @brief MCE illegal access clear register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $01 constant MCE_IAEF                       \ [0x01] Illegal access error flag clear
  [then]


  [ifdef] MCE_MCE_IAIER_DEF
    \
    \ @brief MCE illegal access interrupt enable register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $01 constant MCE_IAEIE                      \ [0x01] Illegal access error interrupt enable
  [then]


  [ifdef] MCE_MCE_IADDR_DEF
    \
    \ @brief MCE illegal address register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant MCE_IADD                       \ [0x00 : 32] Illegal address
  [then]


  [ifdef] MCE_MCE_REGCR1_DEF
    \
    \ @brief MCE region 1 configuration register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant MCE_BREN                       \ [0x00] Base region enable
    $09 constant MCE_CTXID                      \ [0x09 : 2] Context ID
    $0e constant MCE_ENC                        \ [0x0e : 2] Encrypted region
  [then]


  [ifdef] MCE_MCE_SADDR1_DEF
    \
    \ @brief MCE start address for region 1 register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $0c constant MCE_BADDSTART                  \ [0x0c : 20] Region address start
  [then]


  [ifdef] MCE_MCE_EADDR1_DEF
    \
    \ @brief MCE end address for region 1 register
    \ Address offset: 0x48
    \ Reset value: 0x00000FFF
    \
    $0c constant MCE_BADDEND                    \ [0x0c : 20] Region address end
  [then]


  [ifdef] MCE_MCE_REGCR2_DEF
    \
    \ @brief MCE region 2 configuration register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant MCE_BREN                       \ [0x00] Base region enable
    $09 constant MCE_CTXID                      \ [0x09 : 2] Context ID
    $0e constant MCE_ENC                        \ [0x0e : 2] Encrypted region
  [then]


  [ifdef] MCE_MCE_SADDR2_DEF
    \
    \ @brief MCE start address for region 2 register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $0c constant MCE_BADDSTART                  \ [0x0c : 20] Region address start
  [then]


  [ifdef] MCE_MCE_EADDR2_DEF
    \
    \ @brief MCE end address for region 2 register
    \ Address offset: 0x58
    \ Reset value: 0x00000FFF
    \
    $0c constant MCE_BADDEND                    \ [0x0c : 20] Region address end
  [then]


  [ifdef] MCE_MCE_REGCR3_DEF
    \
    \ @brief MCE region 3 configuration register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant MCE_BREN                       \ [0x00] Base region enable
    $09 constant MCE_CTXID                      \ [0x09 : 2] Context ID
    $0e constant MCE_ENC                        \ [0x0e : 2] Encrypted region
  [then]


  [ifdef] MCE_MCE_SADDR3_DEF
    \
    \ @brief MCE start address for region 3 register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $0c constant MCE_BADDSTART                  \ [0x0c : 20] Region address start
  [then]


  [ifdef] MCE_MCE_EADDR3_DEF
    \
    \ @brief MCE end address for region 3 register
    \ Address offset: 0x68
    \ Reset value: 0x00000FFF
    \
    $0c constant MCE_BADDEND                    \ [0x0c : 20] Region address end
  [then]


  [ifdef] MCE_MCE_REGCR4_DEF
    \
    \ @brief MCE region 4 configuration register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant MCE_BREN                       \ [0x00] Base region enable
    $09 constant MCE_CTXID                      \ [0x09 : 2] Context ID
    $0e constant MCE_ENC                        \ [0x0e : 2] Encrypted region
  [then]


  [ifdef] MCE_MCE_SADDR4_DEF
    \
    \ @brief MCE start address for region 4 register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $0c constant MCE_BADDSTART                  \ [0x0c : 20] Region address start
  [then]


  [ifdef] MCE_MCE_EADDR4_DEF
    \
    \ @brief MCE end address for region 4 register
    \ Address offset: 0x78
    \ Reset value: 0x00000FFF
    \
    $0c constant MCE_BADDEND                    \ [0x0c : 20] Region address end
  [then]


  [ifdef] MCE_MCE_MKEYR0_DEF
    \
    \ @brief .MCE master key 0
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant MCE_MKEY0                      \ [0x00] Master key bit 0 (i = 31 to 0)
    $01 constant MCE_MKEY1                      \ [0x01] Master key bit 1 (i = 31 to 0)
    $02 constant MCE_MKEY2                      \ [0x02] Master key bit 2 (i = 31 to 0)
    $03 constant MCE_MKEY3                      \ [0x03] Master key bit 3 (i = 31 to 0)
    $04 constant MCE_MKEY4                      \ [0x04] Master key bit 4 (i = 31 to 0)
    $05 constant MCE_MKEY5                      \ [0x05] Master key bit 5 (i = 31 to 0)
    $06 constant MCE_MKEY6                      \ [0x06] Master key bit 6 (i = 31 to 0)
    $07 constant MCE_MKEY7                      \ [0x07] Master key bit 7 (i = 31 to 0)
    $08 constant MCE_MKEY8                      \ [0x08] Master key bit 8 (i = 31 to 0)
    $09 constant MCE_MKEY9                      \ [0x09] Master key bit 9 (i = 31 to 0)
    $0a constant MCE_MKEY10                     \ [0x0a] Master key bit 10 (i = 31 to 0)
    $0b constant MCE_MKEY11                     \ [0x0b] Master key bit 11 (i = 31 to 0)
    $0c constant MCE_MKEY12                     \ [0x0c] Master key bit 12 (i = 31 to 0)
    $0d constant MCE_MKEY13                     \ [0x0d] Master key bit 13 (i = 31 to 0)
    $0e constant MCE_MKEY14                     \ [0x0e] Master key bit 14 (i = 31 to 0)
    $0f constant MCE_MKEY15                     \ [0x0f] Master key bit 15 (i = 31 to 0)
    $10 constant MCE_MKEY16                     \ [0x10] Master key bit 16 (i = 31 to 0)
    $11 constant MCE_MKEY17                     \ [0x11] Master key bit 17 (i = 31 to 0)
    $12 constant MCE_MKEY18                     \ [0x12] Master key bit 18 (i = 31 to 0)
    $13 constant MCE_MKEY19                     \ [0x13] Master key bit 19 (i = 31 to 0)
    $14 constant MCE_MKEY20                     \ [0x14] Master key bit 20 (i = 31 to 0)
    $15 constant MCE_MKEY21                     \ [0x15] Master key bit 21 (i = 31 to 0)
    $16 constant MCE_MKEY22                     \ [0x16] Master key bit 22 (i = 31 to 0)
    $17 constant MCE_MKEY23                     \ [0x17] Master key bit 23 (i = 31 to 0)
    $18 constant MCE_MKEY24                     \ [0x18] Master key bit 24 (i = 31 to 0)
    $19 constant MCE_MKEY25                     \ [0x19] Master key bit 25 (i = 31 to 0)
    $1a constant MCE_MKEY26                     \ [0x1a] Master key bit 26 (i = 31 to 0)
    $1b constant MCE_MKEY27                     \ [0x1b] Master key bit 27 (i = 31 to 0)
    $1c constant MCE_MKEY28                     \ [0x1c] Master key bit 28 (i = 31 to 0)
    $1d constant MCE_MKEY29                     \ [0x1d] Master key bit 29 (i = 31 to 0)
    $1e constant MCE_MKEY30                     \ [0x1e] Master key bit 30 (i = 31 to 0)
    $1f constant MCE_MKEY31                     \ [0x1f] Master key bit 31 (i = 31 to 0)
  [then]


  [ifdef] MCE_MCE_MKEYR1_DEF
    \
    \ @brief .MCE master key 1
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant MCE_MKEY32                     \ [0x00] Master key bit 32 (i = 31 to 0)
    $01 constant MCE_MKEY33                     \ [0x01] Master key bit 33 (i = 31 to 0)
    $02 constant MCE_MKEY34                     \ [0x02] Master key bit 34 (i = 31 to 0)
    $03 constant MCE_MKEY35                     \ [0x03] Master key bit 35 (i = 31 to 0)
    $04 constant MCE_MKEY36                     \ [0x04] Master key bit 36 (i = 31 to 0)
    $05 constant MCE_MKEY37                     \ [0x05] Master key bit 37 (i = 31 to 0)
    $06 constant MCE_MKEY38                     \ [0x06] Master key bit 38 (i = 31 to 0)
    $07 constant MCE_MKEY39                     \ [0x07] Master key bit 39 (i = 31 to 0)
    $08 constant MCE_MKEY40                     \ [0x08] Master key bit 40 (i = 31 to 0)
    $09 constant MCE_MKEY41                     \ [0x09] Master key bit 41 (i = 31 to 0)
    $0a constant MCE_MKEY42                     \ [0x0a] Master key bit 42 (i = 31 to 0)
    $0b constant MCE_MKEY43                     \ [0x0b] Master key bit 43 (i = 31 to 0)
    $0c constant MCE_MKEY44                     \ [0x0c] Master key bit 44 (i = 31 to 0)
    $0d constant MCE_MKEY45                     \ [0x0d] Master key bit 45 (i = 31 to 0)
    $0e constant MCE_MKEY46                     \ [0x0e] Master key bit 46 (i = 31 to 0)
    $0f constant MCE_MKEY47                     \ [0x0f] Master key bit 47 (i = 31 to 0)
    $10 constant MCE_MKEY48                     \ [0x10] Master key bit 48 (i = 31 to 0)
    $11 constant MCE_MKEY49                     \ [0x11] Master key bit 49 (i = 31 to 0)
    $12 constant MCE_MKEY50                     \ [0x12] Master key bit 50 (i = 31 to 0)
    $13 constant MCE_MKEY51                     \ [0x13] Master key bit 51 (i = 31 to 0)
    $14 constant MCE_MKEY52                     \ [0x14] Master key bit 52 (i = 31 to 0)
    $15 constant MCE_MKEY53                     \ [0x15] Master key bit 53 (i = 31 to 0)
    $16 constant MCE_MKEY54                     \ [0x16] Master key bit 54 (i = 31 to 0)
    $17 constant MCE_MKEY55                     \ [0x17] Master key bit 55 (i = 31 to 0)
    $18 constant MCE_MKEY56                     \ [0x18] Master key bit 56 (i = 31 to 0)
    $19 constant MCE_MKEY57                     \ [0x19] Master key bit 57 (i = 31 to 0)
    $1a constant MCE_MKEY58                     \ [0x1a] Master key bit 58 (i = 31 to 0)
    $1b constant MCE_MKEY59                     \ [0x1b] Master key bit 59 (i = 31 to 0)
    $1c constant MCE_MKEY60                     \ [0x1c] Master key bit 60 (i = 31 to 0)
    $1d constant MCE_MKEY61                     \ [0x1d] Master key bit 61 (i = 31 to 0)
    $1e constant MCE_MKEY62                     \ [0x1e] Master key bit 62 (i = 31 to 0)
    $1f constant MCE_MKEY63                     \ [0x1f] Master key bit 63 (i = 31 to 0)
  [then]


  [ifdef] MCE_MCE_MKEYR2_DEF
    \
    \ @brief .MCE master key 2
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant MCE_MKEY64                     \ [0x00] Master key bit 64 (i = 31 to 0)
    $01 constant MCE_MKEY65                     \ [0x01] Master key bit 65 (i = 31 to 0)
    $02 constant MCE_MKEY66                     \ [0x02] Master key bit 66 (i = 31 to 0)
    $03 constant MCE_MKEY67                     \ [0x03] Master key bit 67 (i = 31 to 0)
    $04 constant MCE_MKEY68                     \ [0x04] Master key bit 68 (i = 31 to 0)
    $05 constant MCE_MKEY69                     \ [0x05] Master key bit 69 (i = 31 to 0)
    $06 constant MCE_MKEY70                     \ [0x06] Master key bit 70 (i = 31 to 0)
    $07 constant MCE_MKEY71                     \ [0x07] Master key bit 71 (i = 31 to 0)
    $08 constant MCE_MKEY72                     \ [0x08] Master key bit 72 (i = 31 to 0)
    $09 constant MCE_MKEY73                     \ [0x09] Master key bit 73 (i = 31 to 0)
    $0a constant MCE_MKEY74                     \ [0x0a] Master key bit 74 (i = 31 to 0)
    $0b constant MCE_MKEY75                     \ [0x0b] Master key bit 75 (i = 31 to 0)
    $0c constant MCE_MKEY76                     \ [0x0c] Master key bit 76 (i = 31 to 0)
    $0d constant MCE_MKEY77                     \ [0x0d] Master key bit 77 (i = 31 to 0)
    $0e constant MCE_MKEY78                     \ [0x0e] Master key bit 78 (i = 31 to 0)
    $0f constant MCE_MKEY79                     \ [0x0f] Master key bit 79 (i = 31 to 0)
    $10 constant MCE_MKEY80                     \ [0x10] Master key bit 80 (i = 31 to 0)
    $11 constant MCE_MKEY81                     \ [0x11] Master key bit 81 (i = 31 to 0)
    $12 constant MCE_MKEY82                     \ [0x12] Master key bit 82 (i = 31 to 0)
    $13 constant MCE_MKEY83                     \ [0x13] Master key bit 83 (i = 31 to 0)
    $14 constant MCE_MKEY84                     \ [0x14] Master key bit 84 (i = 31 to 0)
    $15 constant MCE_MKEY85                     \ [0x15] Master key bit 85 (i = 31 to 0)
    $16 constant MCE_MKEY86                     \ [0x16] Master key bit 86 (i = 31 to 0)
    $17 constant MCE_MKEY87                     \ [0x17] Master key bit 87 (i = 31 to 0)
    $18 constant MCE_MKEY88                     \ [0x18] Master key bit 88 (i = 31 to 0)
    $19 constant MCE_MKEY89                     \ [0x19] Master key bit 89 (i = 31 to 0)
    $1a constant MCE_MKEY90                     \ [0x1a] Master key bit 90 (i = 31 to 0)
    $1b constant MCE_MKEY91                     \ [0x1b] Master key bit 91 (i = 31 to 0)
    $1c constant MCE_MKEY92                     \ [0x1c] Master key bit 92 (i = 31 to 0)
    $1d constant MCE_MKEY93                     \ [0x1d] Master key bit 93 (i = 31 to 0)
    $1e constant MCE_MKEY94                     \ [0x1e] Master key bit 94 (i = 31 to 0)
    $1f constant MCE_MKEY95                     \ [0x1f] Master key bit 95 (i = 31 to 0)
  [then]


  [ifdef] MCE_MCE_MKEYR3_DEF
    \
    \ @brief .MCE master key 3
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant MCE_MKEY96                     \ [0x00] Master key bit 96 (i = 31 to 0)
    $01 constant MCE_MKEY97                     \ [0x01] Master key bit 97 (i = 31 to 0)
    $02 constant MCE_MKEY98                     \ [0x02] Master key bit 98 (i = 31 to 0)
    $03 constant MCE_MKEY99                     \ [0x03] Master key bit 99 (i = 31 to 0)
    $04 constant MCE_MKEY100                    \ [0x04] Master key bit 100 (i = 31 to 0)
    $05 constant MCE_MKEY101                    \ [0x05] Master key bit 101 (i = 31 to 0)
    $06 constant MCE_MKEY102                    \ [0x06] Master key bit 102 (i = 31 to 0)
    $07 constant MCE_MKEY103                    \ [0x07] Master key bit 103 (i = 31 to 0)
    $08 constant MCE_MKEY104                    \ [0x08] Master key bit 104 (i = 31 to 0)
    $09 constant MCE_MKEY105                    \ [0x09] Master key bit 105 (i = 31 to 0)
    $0a constant MCE_MKEY106                    \ [0x0a] Master key bit 106 (i = 31 to 0)
    $0b constant MCE_MKEY107                    \ [0x0b] Master key bit 107 (i = 31 to 0)
    $0c constant MCE_MKEY108                    \ [0x0c] Master key bit 108 (i = 31 to 0)
    $0d constant MCE_MKEY109                    \ [0x0d] Master key bit 109 (i = 31 to 0)
    $0e constant MCE_MKEY110                    \ [0x0e] Master key bit 110 (i = 31 to 0)
    $0f constant MCE_MKEY111                    \ [0x0f] Master key bit 111 (i = 31 to 0)
    $10 constant MCE_MKEY112                    \ [0x10] Master key bit 112 (i = 31 to 0)
    $11 constant MCE_MKEY113                    \ [0x11] Master key bit 113 (i = 31 to 0)
    $12 constant MCE_MKEY114                    \ [0x12] Master key bit 114 (i = 31 to 0)
    $13 constant MCE_MKEY115                    \ [0x13] Master key bit 115 (i = 31 to 0)
    $14 constant MCE_MKEY116                    \ [0x14] Master key bit 116 (i = 31 to 0)
    $15 constant MCE_MKEY117                    \ [0x15] Master key bit 117 (i = 31 to 0)
    $16 constant MCE_MKEY118                    \ [0x16] Master key bit 118 (i = 31 to 0)
    $17 constant MCE_MKEY119                    \ [0x17] Master key bit 119 (i = 31 to 0)
    $18 constant MCE_MKEY120                    \ [0x18] Master key bit 120 (i = 31 to 0)
    $19 constant MCE_MKEY121                    \ [0x19] Master key bit 121 (i = 31 to 0)
    $1a constant MCE_MKEY122                    \ [0x1a] Master key bit 122 (i = 31 to 0)
    $1b constant MCE_MKEY123                    \ [0x1b] Master key bit 123 (i = 31 to 0)
    $1c constant MCE_MKEY124                    \ [0x1c] Master key bit 124 (i = 31 to 0)
    $1d constant MCE_MKEY125                    \ [0x1d] Master key bit 125 (i = 31 to 0)
    $1e constant MCE_MKEY126                    \ [0x1e] Master key bit 126 (i = 31 to 0)
    $1f constant MCE_MKEY127                    \ [0x1f] Master key bit 127 (i = 31 to 0)
  [then]


  [ifdef] MCE_MCE_MKEYR4_DEF
    \
    \ @brief .MCE master key 4
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant MCE_MKEY128                    \ [0x00] Master key bit 128 (i = 31 to 0)
    $01 constant MCE_MKEY129                    \ [0x01] Master key bit 129 (i = 31 to 0)
    $02 constant MCE_MKEY130                    \ [0x02] Master key bit 130 (i = 31 to 0)
    $03 constant MCE_MKEY131                    \ [0x03] Master key bit 131 (i = 31 to 0)
    $04 constant MCE_MKEY132                    \ [0x04] Master key bit 132 (i = 31 to 0)
    $05 constant MCE_MKEY133                    \ [0x05] Master key bit 133 (i = 31 to 0)
    $06 constant MCE_MKEY134                    \ [0x06] Master key bit 134 (i = 31 to 0)
    $07 constant MCE_MKEY135                    \ [0x07] Master key bit 135 (i = 31 to 0)
    $08 constant MCE_MKEY136                    \ [0x08] Master key bit 136 (i = 31 to 0)
    $09 constant MCE_MKEY137                    \ [0x09] Master key bit 137 (i = 31 to 0)
    $0a constant MCE_MKEY138                    \ [0x0a] Master key bit 138 (i = 31 to 0)
    $0b constant MCE_MKEY139                    \ [0x0b] Master key bit 139 (i = 31 to 0)
    $0c constant MCE_MKEY140                    \ [0x0c] Master key bit 140 (i = 31 to 0)
    $0d constant MCE_MKEY141                    \ [0x0d] Master key bit 141 (i = 31 to 0)
    $0e constant MCE_MKEY142                    \ [0x0e] Master key bit 142 (i = 31 to 0)
    $0f constant MCE_MKEY143                    \ [0x0f] Master key bit 143 (i = 31 to 0)
    $10 constant MCE_MKEY144                    \ [0x10] Master key bit 144 (i = 31 to 0)
    $11 constant MCE_MKEY145                    \ [0x11] Master key bit 145 (i = 31 to 0)
    $12 constant MCE_MKEY146                    \ [0x12] Master key bit 146 (i = 31 to 0)
    $13 constant MCE_MKEY147                    \ [0x13] Master key bit 147 (i = 31 to 0)
    $14 constant MCE_MKEY148                    \ [0x14] Master key bit 148 (i = 31 to 0)
    $15 constant MCE_MKEY149                    \ [0x15] Master key bit 149 (i = 31 to 0)
    $16 constant MCE_MKEY150                    \ [0x16] Master key bit 150 (i = 31 to 0)
    $17 constant MCE_MKEY151                    \ [0x17] Master key bit 151 (i = 31 to 0)
    $18 constant MCE_MKEY152                    \ [0x18] Master key bit 152 (i = 31 to 0)
    $19 constant MCE_MKEY153                    \ [0x19] Master key bit 153 (i = 31 to 0)
    $1a constant MCE_MKEY154                    \ [0x1a] Master key bit 154 (i = 31 to 0)
    $1b constant MCE_MKEY155                    \ [0x1b] Master key bit 155 (i = 31 to 0)
    $1c constant MCE_MKEY156                    \ [0x1c] Master key bit 156 (i = 31 to 0)
    $1d constant MCE_MKEY157                    \ [0x1d] Master key bit 157 (i = 31 to 0)
    $1e constant MCE_MKEY158                    \ [0x1e] Master key bit 158 (i = 31 to 0)
    $1f constant MCE_MKEY159                    \ [0x1f] Master key bit 159 (i = 31 to 0)
  [then]


  [ifdef] MCE_MCE_MKEYR5_DEF
    \
    \ @brief .MCE master key 5
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant MCE_MKEY160                    \ [0x00] Master key bit 160 (i = 31 to 0)
    $01 constant MCE_MKEY161                    \ [0x01] Master key bit 161 (i = 31 to 0)
    $02 constant MCE_MKEY162                    \ [0x02] Master key bit 162 (i = 31 to 0)
    $03 constant MCE_MKEY163                    \ [0x03] Master key bit 163 (i = 31 to 0)
    $04 constant MCE_MKEY164                    \ [0x04] Master key bit 164 (i = 31 to 0)
    $05 constant MCE_MKEY165                    \ [0x05] Master key bit 165 (i = 31 to 0)
    $06 constant MCE_MKEY166                    \ [0x06] Master key bit 166 (i = 31 to 0)
    $07 constant MCE_MKEY167                    \ [0x07] Master key bit 167 (i = 31 to 0)
    $08 constant MCE_MKEY168                    \ [0x08] Master key bit 168 (i = 31 to 0)
    $09 constant MCE_MKEY169                    \ [0x09] Master key bit 169 (i = 31 to 0)
    $0a constant MCE_MKEY170                    \ [0x0a] Master key bit 170 (i = 31 to 0)
    $0b constant MCE_MKEY171                    \ [0x0b] Master key bit 171 (i = 31 to 0)
    $0c constant MCE_MKEY172                    \ [0x0c] Master key bit 172 (i = 31 to 0)
    $0d constant MCE_MKEY173                    \ [0x0d] Master key bit 173 (i = 31 to 0)
    $0e constant MCE_MKEY174                    \ [0x0e] Master key bit 174 (i = 31 to 0)
    $0f constant MCE_MKEY175                    \ [0x0f] Master key bit 175 (i = 31 to 0)
    $10 constant MCE_MKEY176                    \ [0x10] Master key bit 176 (i = 31 to 0)
    $11 constant MCE_MKEY177                    \ [0x11] Master key bit 177 (i = 31 to 0)
    $12 constant MCE_MKEY178                    \ [0x12] Master key bit 178 (i = 31 to 0)
    $13 constant MCE_MKEY179                    \ [0x13] Master key bit 179 (i = 31 to 0)
    $14 constant MCE_MKEY180                    \ [0x14] Master key bit 180 (i = 31 to 0)
    $15 constant MCE_MKEY181                    \ [0x15] Master key bit 181 (i = 31 to 0)
    $16 constant MCE_MKEY182                    \ [0x16] Master key bit 182 (i = 31 to 0)
    $17 constant MCE_MKEY183                    \ [0x17] Master key bit 183 (i = 31 to 0)
    $18 constant MCE_MKEY184                    \ [0x18] Master key bit 184 (i = 31 to 0)
    $19 constant MCE_MKEY185                    \ [0x19] Master key bit 185 (i = 31 to 0)
    $1a constant MCE_MKEY186                    \ [0x1a] Master key bit 186 (i = 31 to 0)
    $1b constant MCE_MKEY187                    \ [0x1b] Master key bit 187 (i = 31 to 0)
    $1c constant MCE_MKEY188                    \ [0x1c] Master key bit 188 (i = 31 to 0)
    $1d constant MCE_MKEY189                    \ [0x1d] Master key bit 189 (i = 31 to 0)
    $1e constant MCE_MKEY190                    \ [0x1e] Master key bit 190 (i = 31 to 0)
    $1f constant MCE_MKEY191                    \ [0x1f] Master key bit 191 (i = 31 to 0)
  [then]


  [ifdef] MCE_MCE_MKEYR6_DEF
    \
    \ @brief .MCE master key 6
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant MCE_MKEY192                    \ [0x00] Master key bit 192 (i = 31 to 0)
    $01 constant MCE_MKEY193                    \ [0x01] Master key bit 193 (i = 31 to 0)
    $02 constant MCE_MKEY194                    \ [0x02] Master key bit 194 (i = 31 to 0)
    $03 constant MCE_MKEY195                    \ [0x03] Master key bit 195 (i = 31 to 0)
    $04 constant MCE_MKEY196                    \ [0x04] Master key bit 196 (i = 31 to 0)
    $05 constant MCE_MKEY197                    \ [0x05] Master key bit 197 (i = 31 to 0)
    $06 constant MCE_MKEY198                    \ [0x06] Master key bit 198 (i = 31 to 0)
    $07 constant MCE_MKEY199                    \ [0x07] Master key bit 199 (i = 31 to 0)
    $08 constant MCE_MKEY200                    \ [0x08] Master key bit 200 (i = 31 to 0)
    $09 constant MCE_MKEY201                    \ [0x09] Master key bit 201 (i = 31 to 0)
    $0a constant MCE_MKEY202                    \ [0x0a] Master key bit 202 (i = 31 to 0)
    $0b constant MCE_MKEY203                    \ [0x0b] Master key bit 203 (i = 31 to 0)
    $0c constant MCE_MKEY204                    \ [0x0c] Master key bit 204 (i = 31 to 0)
    $0d constant MCE_MKEY205                    \ [0x0d] Master key bit 205 (i = 31 to 0)
    $0e constant MCE_MKEY206                    \ [0x0e] Master key bit 206 (i = 31 to 0)
    $0f constant MCE_MKEY207                    \ [0x0f] Master key bit 207 (i = 31 to 0)
    $10 constant MCE_MKEY208                    \ [0x10] Master key bit 208 (i = 31 to 0)
    $11 constant MCE_MKEY209                    \ [0x11] Master key bit 209 (i = 31 to 0)
    $12 constant MCE_MKEY210                    \ [0x12] Master key bit 210 (i = 31 to 0)
    $13 constant MCE_MKEY211                    \ [0x13] Master key bit 211 (i = 31 to 0)
    $14 constant MCE_MKEY212                    \ [0x14] Master key bit 212 (i = 31 to 0)
    $15 constant MCE_MKEY213                    \ [0x15] Master key bit 213 (i = 31 to 0)
    $16 constant MCE_MKEY214                    \ [0x16] Master key bit 214 (i = 31 to 0)
    $17 constant MCE_MKEY215                    \ [0x17] Master key bit 215 (i = 31 to 0)
    $18 constant MCE_MKEY216                    \ [0x18] Master key bit 216 (i = 31 to 0)
    $19 constant MCE_MKEY217                    \ [0x19] Master key bit 217 (i = 31 to 0)
    $1a constant MCE_MKEY218                    \ [0x1a] Master key bit 218 (i = 31 to 0)
    $1b constant MCE_MKEY219                    \ [0x1b] Master key bit 219 (i = 31 to 0)
    $1c constant MCE_MKEY220                    \ [0x1c] Master key bit 220 (i = 31 to 0)
    $1d constant MCE_MKEY221                    \ [0x1d] Master key bit 221 (i = 31 to 0)
    $1e constant MCE_MKEY222                    \ [0x1e] Master key bit 222 (i = 31 to 0)
    $1f constant MCE_MKEY223                    \ [0x1f] Master key bit 223 (i = 31 to 0)
  [then]


  [ifdef] MCE_MCE_MKEYR7_DEF
    \
    \ @brief .MCE master key 7
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant MCE_MKEY224                    \ [0x00] Master key bit 224 (i = 31 to 0)
    $01 constant MCE_MKEY225                    \ [0x01] Master key bit 225 (i = 31 to 0)
    $02 constant MCE_MKEY226                    \ [0x02] Master key bit 226 (i = 31 to 0)
    $03 constant MCE_MKEY227                    \ [0x03] Master key bit 227 (i = 31 to 0)
    $04 constant MCE_MKEY228                    \ [0x04] Master key bit 228 (i = 31 to 0)
    $05 constant MCE_MKEY229                    \ [0x05] Master key bit 229 (i = 31 to 0)
    $06 constant MCE_MKEY230                    \ [0x06] Master key bit 230 (i = 31 to 0)
    $07 constant MCE_MKEY231                    \ [0x07] Master key bit 231 (i = 31 to 0)
    $08 constant MCE_MKEY232                    \ [0x08] Master key bit 232 (i = 31 to 0)
    $09 constant MCE_MKEY233                    \ [0x09] Master key bit 233 (i = 31 to 0)
    $0a constant MCE_MKEY234                    \ [0x0a] Master key bit 234 (i = 31 to 0)
    $0b constant MCE_MKEY235                    \ [0x0b] Master key bit 235 (i = 31 to 0)
    $0c constant MCE_MKEY236                    \ [0x0c] Master key bit 236 (i = 31 to 0)
    $0d constant MCE_MKEY237                    \ [0x0d] Master key bit 237 (i = 31 to 0)
    $0e constant MCE_MKEY238                    \ [0x0e] Master key bit 238 (i = 31 to 0)
    $0f constant MCE_MKEY239                    \ [0x0f] Master key bit 239 (i = 31 to 0)
    $10 constant MCE_MKEY240                    \ [0x10] Master key bit 240 (i = 31 to 0)
    $11 constant MCE_MKEY241                    \ [0x11] Master key bit 241 (i = 31 to 0)
    $12 constant MCE_MKEY242                    \ [0x12] Master key bit 242 (i = 31 to 0)
    $13 constant MCE_MKEY243                    \ [0x13] Master key bit 243 (i = 31 to 0)
    $14 constant MCE_MKEY244                    \ [0x14] Master key bit 244 (i = 31 to 0)
    $15 constant MCE_MKEY245                    \ [0x15] Master key bit 245 (i = 31 to 0)
    $16 constant MCE_MKEY246                    \ [0x16] Master key bit 246 (i = 31 to 0)
    $17 constant MCE_MKEY247                    \ [0x17] Master key bit 247 (i = 31 to 0)
    $18 constant MCE_MKEY248                    \ [0x18] Master key bit 248 (i = 31 to 0)
    $19 constant MCE_MKEY249                    \ [0x19] Master key bit 249 (i = 31 to 0)
    $1a constant MCE_MKEY250                    \ [0x1a] Master key bit 250 (i = 31 to 0)
    $1b constant MCE_MKEY251                    \ [0x1b] Master key bit 251 (i = 31 to 0)
    $1c constant MCE_MKEY252                    \ [0x1c] Master key bit 252 (i = 31 to 0)
    $1d constant MCE_MKEY253                    \ [0x1d] Master key bit 253 (i = 31 to 0)
    $1e constant MCE_MKEY254                    \ [0x1e] Master key bit 254 (i = 31 to 0)
    $1f constant MCE_MKEY255                    \ [0x1f] Master key bit 255 (i = 31 to 0)
  [then]


  [ifdef] MCE_MCE_FMKEYR0_DEF
    \
    \ @brief MCE fast master key 0
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant MCE_FMKEY0                     \ [0x00] Fast master key bit 0 (i = 31 to 0)
    $01 constant MCE_FMKEY1                     \ [0x01] Fast master key bit 1 (i = 31 to 0)
    $02 constant MCE_FMKEY2                     \ [0x02] Fast master key bit 2 (i = 31 to 0)
    $03 constant MCE_FMKEY3                     \ [0x03] Fast master key bit 3 (i = 31 to 0)
    $04 constant MCE_FMKEY4                     \ [0x04] Fast master key bit 4 (i = 31 to 0)
    $05 constant MCE_FMKEY5                     \ [0x05] Fast master key bit 5 (i = 31 to 0)
    $06 constant MCE_FMKEY6                     \ [0x06] Fast master key bit 6 (i = 31 to 0)
    $07 constant MCE_FMKEY7                     \ [0x07] Fast master key bit 7 (i = 31 to 0)
    $08 constant MCE_FMKEY8                     \ [0x08] Fast master key bit 8 (i = 31 to 0)
    $09 constant MCE_FMKEY9                     \ [0x09] Fast master key bit 9 (i = 31 to 0)
    $0a constant MCE_FMKEY10                    \ [0x0a] Fast master key bit 10 (i = 31 to 0)
    $0b constant MCE_FMKEY11                    \ [0x0b] Fast master key bit 11 (i = 31 to 0)
    $0c constant MCE_FMKEY12                    \ [0x0c] Fast master key bit 12 (i = 31 to 0)
    $0d constant MCE_FMKEY13                    \ [0x0d] Fast master key bit 13 (i = 31 to 0)
    $0e constant MCE_FMKEY14                    \ [0x0e] Fast master key bit 14 (i = 31 to 0)
    $0f constant MCE_FMKEY15                    \ [0x0f] Fast master key bit 15 (i = 31 to 0)
    $10 constant MCE_FMKEY16                    \ [0x10] Fast master key bit 16 (i = 31 to 0)
    $11 constant MCE_FMKEY17                    \ [0x11] Fast master key bit 17 (i = 31 to 0)
    $12 constant MCE_FMKEY18                    \ [0x12] Fast master key bit 18 (i = 31 to 0)
    $13 constant MCE_FMKEY19                    \ [0x13] Fast master key bit 19 (i = 31 to 0)
    $14 constant MCE_FMKEY20                    \ [0x14] Fast master key bit 20 (i = 31 to 0)
    $15 constant MCE_FMKEY21                    \ [0x15] Fast master key bit 21 (i = 31 to 0)
    $16 constant MCE_FMKEY22                    \ [0x16] Fast master key bit 22 (i = 31 to 0)
    $17 constant MCE_FMKEY23                    \ [0x17] Fast master key bit 23 (i = 31 to 0)
    $18 constant MCE_FMKEY24                    \ [0x18] Fast master key bit 24 (i = 31 to 0)
    $19 constant MCE_FMKEY25                    \ [0x19] Fast master key bit 25 (i = 31 to 0)
    $1a constant MCE_FMKEY26                    \ [0x1a] Fast master key bit 26 (i = 31 to 0)
    $1b constant MCE_FMKEY27                    \ [0x1b] Fast master key bit 27 (i = 31 to 0)
    $1c constant MCE_FMKEY28                    \ [0x1c] Fast master key bit 28 (i = 31 to 0)
    $1d constant MCE_FMKEY29                    \ [0x1d] Fast master key bit 29 (i = 31 to 0)
    $1e constant MCE_FMKEY30                    \ [0x1e] Fast master key bit 30 (i = 31 to 0)
    $1f constant MCE_FMKEY31                    \ [0x1f] Fast master key bit 31 (i = 31 to 0)
  [then]


  [ifdef] MCE_MCE_FMKEYR1_DEF
    \
    \ @brief MCE fast master key 1
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant MCE_FMKEY32                    \ [0x00] Fast master key bit 32 (i = 31 to 0)
    $01 constant MCE_FMKEY33                    \ [0x01] Fast master key bit 33 (i = 31 to 0)
    $02 constant MCE_FMKEY34                    \ [0x02] Fast master key bit 34 (i = 31 to 0)
    $03 constant MCE_FMKEY35                    \ [0x03] Fast master key bit 35 (i = 31 to 0)
    $04 constant MCE_FMKEY36                    \ [0x04] Fast master key bit 36 (i = 31 to 0)
    $05 constant MCE_FMKEY37                    \ [0x05] Fast master key bit 37 (i = 31 to 0)
    $06 constant MCE_FMKEY38                    \ [0x06] Fast master key bit 38 (i = 31 to 0)
    $07 constant MCE_FMKEY39                    \ [0x07] Fast master key bit 39 (i = 31 to 0)
    $08 constant MCE_FMKEY40                    \ [0x08] Fast master key bit 40 (i = 31 to 0)
    $09 constant MCE_FMKEY41                    \ [0x09] Fast master key bit 41 (i = 31 to 0)
    $0a constant MCE_FMKEY42                    \ [0x0a] Fast master key bit 42 (i = 31 to 0)
    $0b constant MCE_FMKEY43                    \ [0x0b] Fast master key bit 43 (i = 31 to 0)
    $0c constant MCE_FMKEY44                    \ [0x0c] Fast master key bit 44 (i = 31 to 0)
    $0d constant MCE_FMKEY45                    \ [0x0d] Fast master key bit 45 (i = 31 to 0)
    $0e constant MCE_FMKEY46                    \ [0x0e] Fast master key bit 46 (i = 31 to 0)
    $0f constant MCE_FMKEY47                    \ [0x0f] Fast master key bit 47 (i = 31 to 0)
    $10 constant MCE_FMKEY48                    \ [0x10] Fast master key bit 48 (i = 31 to 0)
    $11 constant MCE_FMKEY49                    \ [0x11] Fast master key bit 49 (i = 31 to 0)
    $12 constant MCE_FMKEY50                    \ [0x12] Fast master key bit 50 (i = 31 to 0)
    $13 constant MCE_FMKEY51                    \ [0x13] Fast master key bit 51 (i = 31 to 0)
    $14 constant MCE_FMKEY52                    \ [0x14] Fast master key bit 52 (i = 31 to 0)
    $15 constant MCE_FMKEY53                    \ [0x15] Fast master key bit 53 (i = 31 to 0)
    $16 constant MCE_FMKEY54                    \ [0x16] Fast master key bit 54 (i = 31 to 0)
    $17 constant MCE_FMKEY55                    \ [0x17] Fast master key bit 55 (i = 31 to 0)
    $18 constant MCE_FMKEY56                    \ [0x18] Fast master key bit 56 (i = 31 to 0)
    $19 constant MCE_FMKEY57                    \ [0x19] Fast master key bit 57 (i = 31 to 0)
    $1a constant MCE_FMKEY58                    \ [0x1a] Fast master key bit 58 (i = 31 to 0)
    $1b constant MCE_FMKEY59                    \ [0x1b] Fast master key bit 59 (i = 31 to 0)
    $1c constant MCE_FMKEY60                    \ [0x1c] Fast master key bit 60 (i = 31 to 0)
    $1d constant MCE_FMKEY61                    \ [0x1d] Fast master key bit 61 (i = 31 to 0)
    $1e constant MCE_FMKEY62                    \ [0x1e] Fast master key bit 62 (i = 31 to 0)
    $1f constant MCE_FMKEY63                    \ [0x1f] Fast master key bit 63 (i = 31 to 0)
  [then]


  [ifdef] MCE_MCE_FMKEYR2_DEF
    \
    \ @brief MCE fast master key 2
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant MCE_FMKEY64                    \ [0x00] Fast master key bit 64 (i = 31 to 0)
    $01 constant MCE_FMKEY65                    \ [0x01] Fast master key bit 65 (i = 31 to 0)
    $02 constant MCE_FMKEY66                    \ [0x02] Fast master key bit 66 (i = 31 to 0)
    $03 constant MCE_FMKEY67                    \ [0x03] Fast master key bit 67 (i = 31 to 0)
    $04 constant MCE_FMKEY68                    \ [0x04] Fast master key bit 68 (i = 31 to 0)
    $05 constant MCE_FMKEY69                    \ [0x05] Fast master key bit 69 (i = 31 to 0)
    $06 constant MCE_FMKEY70                    \ [0x06] Fast master key bit 70 (i = 31 to 0)
    $07 constant MCE_FMKEY71                    \ [0x07] Fast master key bit 71 (i = 31 to 0)
    $08 constant MCE_FMKEY72                    \ [0x08] Fast master key bit 72 (i = 31 to 0)
    $09 constant MCE_FMKEY73                    \ [0x09] Fast master key bit 73 (i = 31 to 0)
    $0a constant MCE_FMKEY74                    \ [0x0a] Fast master key bit 74 (i = 31 to 0)
    $0b constant MCE_FMKEY75                    \ [0x0b] Fast master key bit 75 (i = 31 to 0)
    $0c constant MCE_FMKEY76                    \ [0x0c] Fast master key bit 76 (i = 31 to 0)
    $0d constant MCE_FMKEY77                    \ [0x0d] Fast master key bit 77 (i = 31 to 0)
    $0e constant MCE_FMKEY78                    \ [0x0e] Fast master key bit 78 (i = 31 to 0)
    $0f constant MCE_FMKEY79                    \ [0x0f] Fast master key bit 79 (i = 31 to 0)
    $10 constant MCE_FMKEY80                    \ [0x10] Fast master key bit 80 (i = 31 to 0)
    $11 constant MCE_FMKEY81                    \ [0x11] Fast master key bit 81 (i = 31 to 0)
    $12 constant MCE_FMKEY82                    \ [0x12] Fast master key bit 82 (i = 31 to 0)
    $13 constant MCE_FMKEY83                    \ [0x13] Fast master key bit 83 (i = 31 to 0)
    $14 constant MCE_FMKEY84                    \ [0x14] Fast master key bit 84 (i = 31 to 0)
    $15 constant MCE_FMKEY85                    \ [0x15] Fast master key bit 85 (i = 31 to 0)
    $16 constant MCE_FMKEY86                    \ [0x16] Fast master key bit 86 (i = 31 to 0)
    $17 constant MCE_FMKEY87                    \ [0x17] Fast master key bit 87 (i = 31 to 0)
    $18 constant MCE_FMKEY88                    \ [0x18] Fast master key bit 88 (i = 31 to 0)
    $19 constant MCE_FMKEY89                    \ [0x19] Fast master key bit 89 (i = 31 to 0)
    $1a constant MCE_FMKEY90                    \ [0x1a] Fast master key bit 90 (i = 31 to 0)
    $1b constant MCE_FMKEY91                    \ [0x1b] Fast master key bit 91 (i = 31 to 0)
    $1c constant MCE_FMKEY92                    \ [0x1c] Fast master key bit 92 (i = 31 to 0)
    $1d constant MCE_FMKEY93                    \ [0x1d] Fast master key bit 93 (i = 31 to 0)
    $1e constant MCE_FMKEY94                    \ [0x1e] Fast master key bit 94 (i = 31 to 0)
    $1f constant MCE_FMKEY95                    \ [0x1f] Fast master key bit 95 (i = 31 to 0)
  [then]


  [ifdef] MCE_MCE_FMKEYR3_DEF
    \
    \ @brief MCE fast master key 3
    \ Address offset: 0x22C
    \ Reset value: 0x00000000
    \
    $00 constant MCE_FMKEY96                    \ [0x00] Fast master key bit 96 (i = 31 to 0)
    $01 constant MCE_FMKEY97                    \ [0x01] Fast master key bit 97 (i = 31 to 0)
    $02 constant MCE_FMKEY98                    \ [0x02] Fast master key bit 98 (i = 31 to 0)
    $03 constant MCE_FMKEY99                    \ [0x03] Fast master key bit 99 (i = 31 to 0)
    $04 constant MCE_FMKEY100                   \ [0x04] Fast master key bit 100 (i = 31 to 0)
    $05 constant MCE_FMKEY101                   \ [0x05] Fast master key bit 101 (i = 31 to 0)
    $06 constant MCE_FMKEY102                   \ [0x06] Fast master key bit 102 (i = 31 to 0)
    $07 constant MCE_FMKEY103                   \ [0x07] Fast master key bit 103 (i = 31 to 0)
    $08 constant MCE_FMKEY104                   \ [0x08] Fast master key bit 104 (i = 31 to 0)
    $09 constant MCE_FMKEY105                   \ [0x09] Fast master key bit 105 (i = 31 to 0)
    $0a constant MCE_FMKEY106                   \ [0x0a] Fast master key bit 106 (i = 31 to 0)
    $0b constant MCE_FMKEY107                   \ [0x0b] Fast master key bit 107 (i = 31 to 0)
    $0c constant MCE_FMKEY108                   \ [0x0c] Fast master key bit 108 (i = 31 to 0)
    $0d constant MCE_FMKEY109                   \ [0x0d] Fast master key bit 109 (i = 31 to 0)
    $0e constant MCE_FMKEY110                   \ [0x0e] Fast master key bit 110 (i = 31 to 0)
    $0f constant MCE_FMKEY111                   \ [0x0f] Fast master key bit 111 (i = 31 to 0)
    $10 constant MCE_FMKEY112                   \ [0x10] Fast master key bit 112 (i = 31 to 0)
    $11 constant MCE_FMKEY113                   \ [0x11] Fast master key bit 113 (i = 31 to 0)
    $12 constant MCE_FMKEY114                   \ [0x12] Fast master key bit 114 (i = 31 to 0)
    $13 constant MCE_FMKEY115                   \ [0x13] Fast master key bit 115 (i = 31 to 0)
    $14 constant MCE_FMKEY116                   \ [0x14] Fast master key bit 116 (i = 31 to 0)
    $15 constant MCE_FMKEY117                   \ [0x15] Fast master key bit 117 (i = 31 to 0)
    $16 constant MCE_FMKEY118                   \ [0x16] Fast master key bit 118 (i = 31 to 0)
    $17 constant MCE_FMKEY119                   \ [0x17] Fast master key bit 119 (i = 31 to 0)
    $18 constant MCE_FMKEY120                   \ [0x18] Fast master key bit 120 (i = 31 to 0)
    $19 constant MCE_FMKEY121                   \ [0x19] Fast master key bit 121 (i = 31 to 0)
    $1a constant MCE_FMKEY122                   \ [0x1a] Fast master key bit 122 (i = 31 to 0)
    $1b constant MCE_FMKEY123                   \ [0x1b] Fast master key bit 123 (i = 31 to 0)
    $1c constant MCE_FMKEY124                   \ [0x1c] Fast master key bit 124 (i = 31 to 0)
    $1d constant MCE_FMKEY125                   \ [0x1d] Fast master key bit 125 (i = 31 to 0)
    $1e constant MCE_FMKEY126                   \ [0x1e] Fast master key bit 126 (i = 31 to 0)
    $1f constant MCE_FMKEY127                   \ [0x1f] Fast master key bit 127 (i = 31 to 0)
  [then]


  [ifdef] MCE_MCE_FMKEYR4_DEF
    \
    \ @brief MCE fast master key 4
    \ Address offset: 0x230
    \ Reset value: 0x00000000
    \
    $00 constant MCE_FMKEY128                   \ [0x00] Fast master key bit 128 (i = 31 to 0)
    $01 constant MCE_FMKEY129                   \ [0x01] Fast master key bit 129 (i = 31 to 0)
    $02 constant MCE_FMKEY130                   \ [0x02] Fast master key bit 130 (i = 31 to 0)
    $03 constant MCE_FMKEY131                   \ [0x03] Fast master key bit 131 (i = 31 to 0)
    $04 constant MCE_FMKEY132                   \ [0x04] Fast master key bit 132 (i = 31 to 0)
    $05 constant MCE_FMKEY133                   \ [0x05] Fast master key bit 133 (i = 31 to 0)
    $06 constant MCE_FMKEY134                   \ [0x06] Fast master key bit 134 (i = 31 to 0)
    $07 constant MCE_FMKEY135                   \ [0x07] Fast master key bit 135 (i = 31 to 0)
    $08 constant MCE_FMKEY136                   \ [0x08] Fast master key bit 136 (i = 31 to 0)
    $09 constant MCE_FMKEY137                   \ [0x09] Fast master key bit 137 (i = 31 to 0)
    $0a constant MCE_FMKEY138                   \ [0x0a] Fast master key bit 138 (i = 31 to 0)
    $0b constant MCE_FMKEY139                   \ [0x0b] Fast master key bit 139 (i = 31 to 0)
    $0c constant MCE_FMKEY140                   \ [0x0c] Fast master key bit 140 (i = 31 to 0)
    $0d constant MCE_FMKEY141                   \ [0x0d] Fast master key bit 141 (i = 31 to 0)
    $0e constant MCE_FMKEY142                   \ [0x0e] Fast master key bit 142 (i = 31 to 0)
    $0f constant MCE_FMKEY143                   \ [0x0f] Fast master key bit 143 (i = 31 to 0)
    $10 constant MCE_FMKEY144                   \ [0x10] Fast master key bit 144 (i = 31 to 0)
    $11 constant MCE_FMKEY145                   \ [0x11] Fast master key bit 145 (i = 31 to 0)
    $12 constant MCE_FMKEY146                   \ [0x12] Fast master key bit 146 (i = 31 to 0)
    $13 constant MCE_FMKEY147                   \ [0x13] Fast master key bit 147 (i = 31 to 0)
    $14 constant MCE_FMKEY148                   \ [0x14] Fast master key bit 148 (i = 31 to 0)
    $15 constant MCE_FMKEY149                   \ [0x15] Fast master key bit 149 (i = 31 to 0)
    $16 constant MCE_FMKEY150                   \ [0x16] Fast master key bit 150 (i = 31 to 0)
    $17 constant MCE_FMKEY151                   \ [0x17] Fast master key bit 151 (i = 31 to 0)
    $18 constant MCE_FMKEY152                   \ [0x18] Fast master key bit 152 (i = 31 to 0)
    $19 constant MCE_FMKEY153                   \ [0x19] Fast master key bit 153 (i = 31 to 0)
    $1a constant MCE_FMKEY154                   \ [0x1a] Fast master key bit 154 (i = 31 to 0)
    $1b constant MCE_FMKEY155                   \ [0x1b] Fast master key bit 155 (i = 31 to 0)
    $1c constant MCE_FMKEY156                   \ [0x1c] Fast master key bit 156 (i = 31 to 0)
    $1d constant MCE_FMKEY157                   \ [0x1d] Fast master key bit 157 (i = 31 to 0)
    $1e constant MCE_FMKEY158                   \ [0x1e] Fast master key bit 158 (i = 31 to 0)
    $1f constant MCE_FMKEY159                   \ [0x1f] Fast master key bit 159 (i = 31 to 0)
  [then]


  [ifdef] MCE_MCE_FMKEYR5_DEF
    \
    \ @brief MCE fast master key 5
    \ Address offset: 0x234
    \ Reset value: 0x00000000
    \
    $00 constant MCE_FMKEY160                   \ [0x00] Fast master key bit 160 (i = 31 to 0)
    $01 constant MCE_FMKEY161                   \ [0x01] Fast master key bit 161 (i = 31 to 0)
    $02 constant MCE_FMKEY162                   \ [0x02] Fast master key bit 162 (i = 31 to 0)
    $03 constant MCE_FMKEY163                   \ [0x03] Fast master key bit 163 (i = 31 to 0)
    $04 constant MCE_FMKEY164                   \ [0x04] Fast master key bit 164 (i = 31 to 0)
    $05 constant MCE_FMKEY165                   \ [0x05] Fast master key bit 165 (i = 31 to 0)
    $06 constant MCE_FMKEY166                   \ [0x06] Fast master key bit 166 (i = 31 to 0)
    $07 constant MCE_FMKEY167                   \ [0x07] Fast master key bit 167 (i = 31 to 0)
    $08 constant MCE_FMKEY168                   \ [0x08] Fast master key bit 168 (i = 31 to 0)
    $09 constant MCE_FMKEY169                   \ [0x09] Fast master key bit 169 (i = 31 to 0)
    $0a constant MCE_FMKEY170                   \ [0x0a] Fast master key bit 170 (i = 31 to 0)
    $0b constant MCE_FMKEY171                   \ [0x0b] Fast master key bit 171 (i = 31 to 0)
    $0c constant MCE_FMKEY172                   \ [0x0c] Fast master key bit 172 (i = 31 to 0)
    $0d constant MCE_FMKEY173                   \ [0x0d] Fast master key bit 173 (i = 31 to 0)
    $0e constant MCE_FMKEY174                   \ [0x0e] Fast master key bit 174 (i = 31 to 0)
    $0f constant MCE_FMKEY175                   \ [0x0f] Fast master key bit 175 (i = 31 to 0)
    $10 constant MCE_FMKEY176                   \ [0x10] Fast master key bit 176 (i = 31 to 0)
    $11 constant MCE_FMKEY177                   \ [0x11] Fast master key bit 177 (i = 31 to 0)
    $12 constant MCE_FMKEY178                   \ [0x12] Fast master key bit 178 (i = 31 to 0)
    $13 constant MCE_FMKEY179                   \ [0x13] Fast master key bit 179 (i = 31 to 0)
    $14 constant MCE_FMKEY180                   \ [0x14] Fast master key bit 180 (i = 31 to 0)
    $15 constant MCE_FMKEY181                   \ [0x15] Fast master key bit 181 (i = 31 to 0)
    $16 constant MCE_FMKEY182                   \ [0x16] Fast master key bit 182 (i = 31 to 0)
    $17 constant MCE_FMKEY183                   \ [0x17] Fast master key bit 183 (i = 31 to 0)
    $18 constant MCE_FMKEY184                   \ [0x18] Fast master key bit 184 (i = 31 to 0)
    $19 constant MCE_FMKEY185                   \ [0x19] Fast master key bit 185 (i = 31 to 0)
    $1a constant MCE_FMKEY186                   \ [0x1a] Fast master key bit 186 (i = 31 to 0)
    $1b constant MCE_FMKEY187                   \ [0x1b] Fast master key bit 187 (i = 31 to 0)
    $1c constant MCE_FMKEY188                   \ [0x1c] Fast master key bit 188 (i = 31 to 0)
    $1d constant MCE_FMKEY189                   \ [0x1d] Fast master key bit 189 (i = 31 to 0)
    $1e constant MCE_FMKEY190                   \ [0x1e] Fast master key bit 190 (i = 31 to 0)
    $1f constant MCE_FMKEY191                   \ [0x1f] Fast master key bit 191 (i = 31 to 0)
  [then]


  [ifdef] MCE_MCE_FMKEYR6_DEF
    \
    \ @brief MCE fast master key 6
    \ Address offset: 0x238
    \ Reset value: 0x00000000
    \
    $00 constant MCE_FMKEY192                   \ [0x00] Fast master key bit 192 (i = 31 to 0)
    $01 constant MCE_FMKEY193                   \ [0x01] Fast master key bit 193 (i = 31 to 0)
    $02 constant MCE_FMKEY194                   \ [0x02] Fast master key bit 194 (i = 31 to 0)
    $03 constant MCE_FMKEY195                   \ [0x03] Fast master key bit 195 (i = 31 to 0)
    $04 constant MCE_FMKEY196                   \ [0x04] Fast master key bit 196 (i = 31 to 0)
    $05 constant MCE_FMKEY197                   \ [0x05] Fast master key bit 197 (i = 31 to 0)
    $06 constant MCE_FMKEY198                   \ [0x06] Fast master key bit 198 (i = 31 to 0)
    $07 constant MCE_FMKEY199                   \ [0x07] Fast master key bit 199 (i = 31 to 0)
    $08 constant MCE_FMKEY200                   \ [0x08] Fast master key bit 200 (i = 31 to 0)
    $09 constant MCE_FMKEY201                   \ [0x09] Fast master key bit 201 (i = 31 to 0)
    $0a constant MCE_FMKEY202                   \ [0x0a] Fast master key bit 202 (i = 31 to 0)
    $0b constant MCE_FMKEY203                   \ [0x0b] Fast master key bit 203 (i = 31 to 0)
    $0c constant MCE_FMKEY204                   \ [0x0c] Fast master key bit 204 (i = 31 to 0)
    $0d constant MCE_FMKEY205                   \ [0x0d] Fast master key bit 205 (i = 31 to 0)
    $0e constant MCE_FMKEY206                   \ [0x0e] Fast master key bit 206 (i = 31 to 0)
    $0f constant MCE_FMKEY207                   \ [0x0f] Fast master key bit 207 (i = 31 to 0)
    $10 constant MCE_FMKEY208                   \ [0x10] Fast master key bit 208 (i = 31 to 0)
    $11 constant MCE_FMKEY209                   \ [0x11] Fast master key bit 209 (i = 31 to 0)
    $12 constant MCE_FMKEY210                   \ [0x12] Fast master key bit 210 (i = 31 to 0)
    $13 constant MCE_FMKEY211                   \ [0x13] Fast master key bit 211 (i = 31 to 0)
    $14 constant MCE_FMKEY212                   \ [0x14] Fast master key bit 212 (i = 31 to 0)
    $15 constant MCE_FMKEY213                   \ [0x15] Fast master key bit 213 (i = 31 to 0)
    $16 constant MCE_FMKEY214                   \ [0x16] Fast master key bit 214 (i = 31 to 0)
    $17 constant MCE_FMKEY215                   \ [0x17] Fast master key bit 215 (i = 31 to 0)
    $18 constant MCE_FMKEY216                   \ [0x18] Fast master key bit 216 (i = 31 to 0)
    $19 constant MCE_FMKEY217                   \ [0x19] Fast master key bit 217 (i = 31 to 0)
    $1a constant MCE_FMKEY218                   \ [0x1a] Fast master key bit 218 (i = 31 to 0)
    $1b constant MCE_FMKEY219                   \ [0x1b] Fast master key bit 219 (i = 31 to 0)
    $1c constant MCE_FMKEY220                   \ [0x1c] Fast master key bit 220 (i = 31 to 0)
    $1d constant MCE_FMKEY221                   \ [0x1d] Fast master key bit 221 (i = 31 to 0)
    $1e constant MCE_FMKEY222                   \ [0x1e] Fast master key bit 222 (i = 31 to 0)
    $1f constant MCE_FMKEY223                   \ [0x1f] Fast master key bit 223 (i = 31 to 0)
  [then]


  [ifdef] MCE_MCE_FMKEYR7_DEF
    \
    \ @brief MCE fast master key 7
    \ Address offset: 0x23C
    \ Reset value: 0x00000000
    \
    $00 constant MCE_FMKEY224                   \ [0x00] Fast master key bit 224 (i = 31 to 0)
    $01 constant MCE_FMKEY225                   \ [0x01] Fast master key bit 225 (i = 31 to 0)
    $02 constant MCE_FMKEY226                   \ [0x02] Fast master key bit 226 (i = 31 to 0)
    $03 constant MCE_FMKEY227                   \ [0x03] Fast master key bit 227 (i = 31 to 0)
    $04 constant MCE_FMKEY228                   \ [0x04] Fast master key bit 228 (i = 31 to 0)
    $05 constant MCE_FMKEY229                   \ [0x05] Fast master key bit 229 (i = 31 to 0)
    $06 constant MCE_FMKEY230                   \ [0x06] Fast master key bit 230 (i = 31 to 0)
    $07 constant MCE_FMKEY231                   \ [0x07] Fast master key bit 231 (i = 31 to 0)
    $08 constant MCE_FMKEY232                   \ [0x08] Fast master key bit 232 (i = 31 to 0)
    $09 constant MCE_FMKEY233                   \ [0x09] Fast master key bit 233 (i = 31 to 0)
    $0a constant MCE_FMKEY234                   \ [0x0a] Fast master key bit 234 (i = 31 to 0)
    $0b constant MCE_FMKEY235                   \ [0x0b] Fast master key bit 235 (i = 31 to 0)
    $0c constant MCE_FMKEY236                   \ [0x0c] Fast master key bit 236 (i = 31 to 0)
    $0d constant MCE_FMKEY237                   \ [0x0d] Fast master key bit 237 (i = 31 to 0)
    $0e constant MCE_FMKEY238                   \ [0x0e] Fast master key bit 238 (i = 31 to 0)
    $0f constant MCE_FMKEY239                   \ [0x0f] Fast master key bit 239 (i = 31 to 0)
    $10 constant MCE_FMKEY240                   \ [0x10] Fast master key bit 240 (i = 31 to 0)
    $11 constant MCE_FMKEY241                   \ [0x11] Fast master key bit 241 (i = 31 to 0)
    $12 constant MCE_FMKEY242                   \ [0x12] Fast master key bit 242 (i = 31 to 0)
    $13 constant MCE_FMKEY243                   \ [0x13] Fast master key bit 243 (i = 31 to 0)
    $14 constant MCE_FMKEY244                   \ [0x14] Fast master key bit 244 (i = 31 to 0)
    $15 constant MCE_FMKEY245                   \ [0x15] Fast master key bit 245 (i = 31 to 0)
    $16 constant MCE_FMKEY246                   \ [0x16] Fast master key bit 246 (i = 31 to 0)
    $17 constant MCE_FMKEY247                   \ [0x17] Fast master key bit 247 (i = 31 to 0)
    $18 constant MCE_FMKEY248                   \ [0x18] Fast master key bit 248 (i = 31 to 0)
    $19 constant MCE_FMKEY249                   \ [0x19] Fast master key bit 249 (i = 31 to 0)
    $1a constant MCE_FMKEY250                   \ [0x1a] Fast master key bit 250 (i = 31 to 0)
    $1b constant MCE_FMKEY251                   \ [0x1b] Fast master key bit 251 (i = 31 to 0)
    $1c constant MCE_FMKEY252                   \ [0x1c] Fast master key bit 252 (i = 31 to 0)
    $1d constant MCE_FMKEY253                   \ [0x1d] Fast master key bit 253 (i = 31 to 0)
    $1e constant MCE_FMKEY254                   \ [0x1e] Fast master key bit 254 (i = 31 to 0)
    $1f constant MCE_FMKEY255                   \ [0x1f] Fast master key bit 255 (i = 31 to 0)
  [then]


  [ifdef] MCE_MCE_CC1CFGR_DEF
    \
    \ @brief MCE cipher context 1 configuration register
    \ Address offset: 0x240
    \ Reset value: 0x00000000
    \
    $00 constant MCE_CCEN                       \ [0x00] Cipher context enable
    $01 constant MCE_CCLOCK                     \ [0x01] Cipher context lock
    $02 constant MCE_KEYLOCK                    \ [0x02] Key lock
    $04 constant MCE_MODE                       \ [0x04 : 2] Authorized cipher mode
    $08 constant MCE_KEYCRC                     \ [0x08 : 8] Key CRC
    $10 constant MCE_VERSION                    \ [0x10 : 16] Version
  [then]


  [ifdef] MCE_MCE_CC1NR0_DEF
    \
    \ @brief MCE cipher context 1 nonce register 0
    \ Address offset: 0x244
    \ Reset value: 0x00000000
    \
    $00 constant MCE_SCNONCE                    \ [0x00 : 32] Stream cipher nonce, bits [31:0]
  [then]


  [ifdef] MCE_MCE_CC1NR1_DEF
    \
    \ @brief MCE cipher context 1 nonce register 1
    \ Address offset: 0x248
    \ Reset value: 0x00000000
    \
    $00 constant MCE_SCNONCE                    \ [0x00 : 32] Stream cipher nonce, bits [63:32]
  [then]


  [ifdef] MCE_MCE_CC1KEYR0_DEF
    \
    \ @brief MCE cipher context 1 key register 0
    \ Address offset: 0x24C
    \ Reset value: 0x00000000
    \
    $00 constant MCE_KEY                        \ [0x00 : 32] cipher key, bits [31:0]
  [then]


  [ifdef] MCE_MCE_CC1KEYR1_DEF
    \
    \ @brief MCE cipher context 1 key register 1
    \ Address offset: 0x250
    \ Reset value: 0x00000000
    \
    $00 constant MCE_KEY                        \ [0x00 : 32] cipher key, bits [63:32]
  [then]


  [ifdef] MCE_MCE_CC1KEYR2_DEF
    \
    \ @brief MCE cipher context 1 key register 2
    \ Address offset: 0x254
    \ Reset value: 0x00000000
    \
    $00 constant MCE_KEY                        \ [0x00 : 32] cipher key, bits [95:64]
  [then]


  [ifdef] MCE_MCE_CC1KEYR3_DEF
    \
    \ @brief MCE cipher context 1 key register 3
    \ Address offset: 0x258
    \ Reset value: 0x00000000
    \
    $00 constant MCE_KEY                        \ [0x00 : 32] cipher key, bits [127:96]
  [then]


  [ifdef] MCE_MCE_CC2CFGR_DEF
    \
    \ @brief MCE cipher context 2 configuration register
    \ Address offset: 0x270
    \ Reset value: 0x00000000
    \
    $00 constant MCE_CCEN                       \ [0x00] Cipher context enable
    $01 constant MCE_CCLOCK                     \ [0x01] Cipher context lock
    $02 constant MCE_KEYLOCK                    \ [0x02] Key lock
    $04 constant MCE_MODE                       \ [0x04 : 2] Authorized cipher mode
    $08 constant MCE_KEYCRC                     \ [0x08 : 8] Key CRC
    $10 constant MCE_VERSION                    \ [0x10 : 16] Version
  [then]


  [ifdef] MCE_MCE_CC2NR0_DEF
    \
    \ @brief MCE cipher context 2 nonce register 0
    \ Address offset: 0x274
    \ Reset value: 0x00000000
    \
    $00 constant MCE_SCNONCE                    \ [0x00 : 32] Stream cipher nonce, bits [31:0]
  [then]


  [ifdef] MCE_MCE_CC2NR1_DEF
    \
    \ @brief MCE cipher context 2 nonce register 1
    \ Address offset: 0x278
    \ Reset value: 0x00000000
    \
    $00 constant MCE_SCNONCE                    \ [0x00 : 32] Stream cipher nonce, bits [63:32]
  [then]


  [ifdef] MCE_MCE_CC2KEYR0_DEF
    \
    \ @brief MCE cipher context 2 key register 0
    \ Address offset: 0x27C
    \ Reset value: 0x00000000
    \
    $00 constant MCE_KEY                        \ [0x00 : 32] cipher key, bits [31:0]
  [then]


  [ifdef] MCE_MCE_CC2KEYR1_DEF
    \
    \ @brief MCE cipher context 2 key register 1
    \ Address offset: 0x280
    \ Reset value: 0x00000000
    \
    $00 constant MCE_KEY                        \ [0x00 : 32] cipher key, bits [63:32]
  [then]


  [ifdef] MCE_MCE_CC2KEYR2_DEF
    \
    \ @brief MCE cipher context 2 key register 2
    \ Address offset: 0x284
    \ Reset value: 0x00000000
    \
    $00 constant MCE_KEY                        \ [0x00 : 32] cipher key, bits [95:64]
  [then]


  [ifdef] MCE_MCE_CC2KEYR3_DEF
    \
    \ @brief MCE cipher context 2 key register 3
    \ Address offset: 0x288
    \ Reset value: 0x00000000
    \
    $00 constant MCE_KEY                        \ [0x00 : 32] cipher key, bits [127:96]
  [then]

  \
  \ @brief Memory cipher engine
  \
  $00 constant MCE_MCE_CR               \ MCE configuration register
  $04 constant MCE_MCE_SR               \ MCE status register
  $08 constant MCE_MCE_IASR             \ MCE illegal access status register
  $0C constant MCE_MCE_IACR             \ MCE illegal access clear register
  $10 constant MCE_MCE_IAIER            \ MCE illegal access interrupt enable register
  $24 constant MCE_MCE_IADDR            \ MCE illegal address register
  $40 constant MCE_MCE_REGCR1           \ MCE region 1 configuration register
  $44 constant MCE_MCE_SADDR1           \ MCE start address for region 1 register
  $48 constant MCE_MCE_EADDR1           \ MCE end address for region 1 register
  $50 constant MCE_MCE_REGCR2           \ MCE region 2 configuration register
  $54 constant MCE_MCE_SADDR2           \ MCE start address for region 2 register
  $58 constant MCE_MCE_EADDR2           \ MCE end address for region 2 register
  $60 constant MCE_MCE_REGCR3           \ MCE region 3 configuration register
  $64 constant MCE_MCE_SADDR3           \ MCE start address for region 3 register
  $68 constant MCE_MCE_EADDR3           \ MCE end address for region 3 register
  $70 constant MCE_MCE_REGCR4           \ MCE region 4 configuration register
  $74 constant MCE_MCE_SADDR4           \ MCE start address for region 4 register
  $78 constant MCE_MCE_EADDR4           \ MCE end address for region 4 register
  $200 constant MCE_MCE_MKEYR0          \ .MCE master key 0
  $204 constant MCE_MCE_MKEYR1          \ .MCE master key 1
  $208 constant MCE_MCE_MKEYR2          \ .MCE master key 2
  $20C constant MCE_MCE_MKEYR3          \ .MCE master key 3
  $210 constant MCE_MCE_MKEYR4          \ .MCE master key 4
  $214 constant MCE_MCE_MKEYR5          \ .MCE master key 5
  $218 constant MCE_MCE_MKEYR6          \ .MCE master key 6
  $21C constant MCE_MCE_MKEYR7          \ .MCE master key 7
  $220 constant MCE_MCE_FMKEYR0         \ MCE fast master key 0
  $224 constant MCE_MCE_FMKEYR1         \ MCE fast master key 1
  $228 constant MCE_MCE_FMKEYR2         \ MCE fast master key 2
  $22C constant MCE_MCE_FMKEYR3         \ MCE fast master key 3
  $230 constant MCE_MCE_FMKEYR4         \ MCE fast master key 4
  $234 constant MCE_MCE_FMKEYR5         \ MCE fast master key 5
  $238 constant MCE_MCE_FMKEYR6         \ MCE fast master key 6
  $23C constant MCE_MCE_FMKEYR7         \ MCE fast master key 7
  $240 constant MCE_MCE_CC1CFGR         \ MCE cipher context 1 configuration register
  $244 constant MCE_MCE_CC1NR0          \ MCE cipher context 1 nonce register 0
  $248 constant MCE_MCE_CC1NR1          \ MCE cipher context 1 nonce register 1
  $24C constant MCE_MCE_CC1KEYR0        \ MCE cipher context 1 key register 0
  $250 constant MCE_MCE_CC1KEYR1        \ MCE cipher context 1 key register 1
  $254 constant MCE_MCE_CC1KEYR2        \ MCE cipher context 1 key register 2
  $258 constant MCE_MCE_CC1KEYR3        \ MCE cipher context 1 key register 3
  $270 constant MCE_MCE_CC2CFGR         \ MCE cipher context 2 configuration register
  $274 constant MCE_MCE_CC2NR0          \ MCE cipher context 2 nonce register 0
  $278 constant MCE_MCE_CC2NR1          \ MCE cipher context 2 nonce register 1
  $27C constant MCE_MCE_CC2KEYR0        \ MCE cipher context 2 key register 0
  $280 constant MCE_MCE_CC2KEYR1        \ MCE cipher context 2 key register 1
  $284 constant MCE_MCE_CC2KEYR2        \ MCE cipher context 2 key register 2
  $288 constant MCE_MCE_CC2KEYR3        \ MCE cipher context 2 key register 3

: MCE_DEF ; [then]
