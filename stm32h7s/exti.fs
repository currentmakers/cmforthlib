\
\ @file exti.fs
\ @brief Extended interrupt and event controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] EXTI_DEF

  [ifdef] EXTI_EXTI_RTSR1_DEF
    \
    \ @brief EXTI rising trigger selection register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_TR0                       \ [0x00] Rising trigger event configuration bit of configurable event input x.
    $01 constant EXTI_TR1                       \ [0x01] Rising trigger event configuration bit of configurable event input x.
    $02 constant EXTI_TR2                       \ [0x02] Rising trigger event configuration bit of configurable event input x.
    $03 constant EXTI_TR3                       \ [0x03] Rising trigger event configuration bit of configurable event input x.
    $04 constant EXTI_TR4                       \ [0x04] Rising trigger event configuration bit of configurable event input x.
    $05 constant EXTI_TR5                       \ [0x05] Rising trigger event configuration bit of configurable event input x.
    $06 constant EXTI_TR6                       \ [0x06] Rising trigger event configuration bit of configurable event input x.
    $07 constant EXTI_TR7                       \ [0x07] Rising trigger event configuration bit of configurable event input x.
    $08 constant EXTI_TR8                       \ [0x08] Rising trigger event configuration bit of configurable event input x.
    $09 constant EXTI_TR9                       \ [0x09] Rising trigger event configuration bit of configurable event input x.
    $0a constant EXTI_TR10                      \ [0x0a] Rising trigger event configuration bit of configurable event input x.
    $0b constant EXTI_TR11                      \ [0x0b] Rising trigger event configuration bit of configurable event input x.
    $0c constant EXTI_TR12                      \ [0x0c] Rising trigger event configuration bit of configurable event input x.
    $0d constant EXTI_TR13                      \ [0x0d] Rising trigger event configuration bit of configurable event input x.
    $0e constant EXTI_TR14                      \ [0x0e] Rising trigger event configuration bit of configurable event input x.
    $0f constant EXTI_TR15                      \ [0x0f] Rising trigger event configuration bit of configurable event input x.
    $10 constant EXTI_TR16                      \ [0x10] Rising trigger event configuration bit of configurable event input x.
    $11 constant EXTI_TR17                      \ [0x11] Rising trigger event configuration bit of configurable event input x.
    $12 constant EXTI_TR18                      \ [0x12] Rising trigger event configuration bit of configurable event input x.
    $13 constant EXTI_TR19                      \ [0x13] Rising trigger event configuration bit of configurable event input x.
    $14 constant EXTI_TR20                      \ [0x14] Rising trigger event configuration bit of configurable event input x.
    $15 constant EXTI_TR21                      \ [0x15] Rising trigger event configuration bit of configurable event input x.
  [then]


  [ifdef] EXTI_EXTI_FTSR1_DEF
    \
    \ @brief EXTI falling trigger selection register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_TR0                       \ [0x00] Falling trigger event configuration bit of configurable event input x.
    $01 constant EXTI_TR1                       \ [0x01] Falling trigger event configuration bit of configurable event input x.
    $02 constant EXTI_TR2                       \ [0x02] Falling trigger event configuration bit of configurable event input x.
    $03 constant EXTI_TR3                       \ [0x03] Falling trigger event configuration bit of configurable event input x.
    $04 constant EXTI_TR4                       \ [0x04] Falling trigger event configuration bit of configurable event input x.
    $05 constant EXTI_TR5                       \ [0x05] Falling trigger event configuration bit of configurable event input x.
    $06 constant EXTI_TR6                       \ [0x06] Falling trigger event configuration bit of configurable event input x.
    $07 constant EXTI_TR7                       \ [0x07] Falling trigger event configuration bit of configurable event input x.
    $08 constant EXTI_TR8                       \ [0x08] Falling trigger event configuration bit of configurable event input x.
    $09 constant EXTI_TR9                       \ [0x09] Falling trigger event configuration bit of configurable event input x.
    $0a constant EXTI_TR10                      \ [0x0a] Falling trigger event configuration bit of configurable event input x.
    $0b constant EXTI_TR11                      \ [0x0b] Falling trigger event configuration bit of configurable event input x.
    $0c constant EXTI_TR12                      \ [0x0c] Falling trigger event configuration bit of configurable event input x.
    $0d constant EXTI_TR13                      \ [0x0d] Falling trigger event configuration bit of configurable event input x.
    $0e constant EXTI_TR14                      \ [0x0e] Falling trigger event configuration bit of configurable event input x.
    $0f constant EXTI_TR15                      \ [0x0f] Falling trigger event configuration bit of configurable event input x.
    $10 constant EXTI_TR16                      \ [0x10] Falling trigger event configuration bit of configurable event input x.
    $11 constant EXTI_TR17                      \ [0x11] Falling trigger event configuration bit of configurable event input x.
    $12 constant EXTI_TR18                      \ [0x12] Falling trigger event configuration bit of configurable event input x.
    $13 constant EXTI_TR19                      \ [0x13] Falling trigger event configuration bit of configurable event input x.
    $14 constant EXTI_TR20                      \ [0x14] Falling trigger event configuration bit of configurable event input x.
    $15 constant EXTI_TR21                      \ [0x15] Falling trigger event configuration bit of configurable event input x.
  [then]


  [ifdef] EXTI_EXTI_SWIER1_DEF
    \
    \ @brief EXTI software interrupt event register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_SWIER0                    \ [0x00] Software interrupt on line x This bitfield alway returns 0 when read.
    $01 constant EXTI_SWIER1                    \ [0x01] Software interrupt on line x This bitfield alway returns 0 when read.
    $02 constant EXTI_SWIER2                    \ [0x02] Software interrupt on line x This bitfield alway returns 0 when read.
    $03 constant EXTI_SWIER3                    \ [0x03] Software interrupt on line x This bitfield alway returns 0 when read.
    $04 constant EXTI_SWIER4                    \ [0x04] Software interrupt on line x This bitfield alway returns 0 when read.
    $05 constant EXTI_SWIER5                    \ [0x05] Software interrupt on line x This bitfield alway returns 0 when read.
    $06 constant EXTI_SWIER6                    \ [0x06] Software interrupt on line x This bitfield alway returns 0 when read.
    $07 constant EXTI_SWIER7                    \ [0x07] Software interrupt on line x This bitfield alway returns 0 when read.
    $08 constant EXTI_SWIER8                    \ [0x08] Software interrupt on line x This bitfield alway returns 0 when read.
    $09 constant EXTI_SWIER9                    \ [0x09] Software interrupt on line x This bitfield alway returns 0 when read.
    $0a constant EXTI_SWIER10                   \ [0x0a] Software interrupt on line x This bitfield alway returns 0 when read.
    $0b constant EXTI_SWIER11                   \ [0x0b] Software interrupt on line x This bitfield alway returns 0 when read.
    $0c constant EXTI_SWIER12                   \ [0x0c] Software interrupt on line x This bitfield alway returns 0 when read.
    $0d constant EXTI_SWIER13                   \ [0x0d] Software interrupt on line x This bitfield alway returns 0 when read.
    $0e constant EXTI_SWIER14                   \ [0x0e] Software interrupt on line x This bitfield alway returns 0 when read.
    $0f constant EXTI_SWIER15                   \ [0x0f] Software interrupt on line x This bitfield alway returns 0 when read.
    $10 constant EXTI_SWIER16                   \ [0x10] Software interrupt on line x This bitfield alway returns 0 when read.
    $11 constant EXTI_SWIER17                   \ [0x11] Software interrupt on line x This bitfield alway returns 0 when read.
    $12 constant EXTI_SWIER18                   \ [0x12] Software interrupt on line x This bitfield alway returns 0 when read.
    $13 constant EXTI_SWIER19                   \ [0x13] Software interrupt on line x This bitfield alway returns 0 when read.
    $14 constant EXTI_SWIER20                   \ [0x14] Software interrupt on line x This bitfield alway returns 0 when read.
    $15 constant EXTI_SWIER21                   \ [0x15] Software interrupt on line x This bitfield alway returns 0 when read.
  [then]


  [ifdef] EXTI_EXTI_RTSR2_DEF
    \
    \ @brief EXTI rising trigger selection register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_TR34                      \ [0x02] Rising trigger event configuration bit of configurable event input x+32.<sup>(1)</sup>
    $0e constant EXTI_TR46                      \ [0x0e] Rising trigger event configuration bit of configurable event input x+32.<sup>(1)</sup>
    $11 constant EXTI_TR49                      \ [0x11] Rising trigger event configuration bit of configurable event input x+32.<sup>(1)</sup>
    $13 constant EXTI_TR51                      \ [0x13] Rising trigger event configuration bit of configurable event input x+32.<sup>(1)</sup>
    $16 constant EXTI_TR54                      \ [0x16] Rising trigger event configuration bit of configurable event input x+32.
  [then]


  [ifdef] EXTI_EXTI_FTSR2_DEF
    \
    \ @brief EXTI falling trigger selection register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_TR34                      \ [0x02] Falling trigger event configuration bit of configurable event input x+32.<sup>(1)</sup>
    $0e constant EXTI_TR46                      \ [0x0e] Falling trigger event configuration bit of configurable event input x+32.<sup>(1)</sup>
    $11 constant EXTI_TR49                      \ [0x11] Falling trigger event configuration bit of configurable event input x+32.<sup>(1)</sup>
    $13 constant EXTI_TR51                      \ [0x13] Falling trigger event configuration bit of configurable event input x+32.<sup>(1)</sup>
    $16 constant EXTI_TR54                      \ [0x16] Falling trigger event configuration bit of configurable event input x+32.
  [then]


  [ifdef] EXTI_EXTI_SWIER2_DEF
    \
    \ @brief EXTI software interrupt event register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_SWIER34                   \ [0x02] Software interrupt on line x+32 Always returns 0 when read.
    $0e constant EXTI_SWIER46                   \ [0x0e] Software interrupt on line x+32 Always returns 0 when read.
    $11 constant EXTI_SWIER49                   \ [0x11] Software interrupt on line x+32 Always returns 0 when read.
    $13 constant EXTI_SWIER51                   \ [0x13] Software interrupt on line x+32 Always returns 0 when read.
    $16 constant EXTI_SWIER54                   \ [0x16] Software interrupt on line x+32 Always returns 0 when read.
  [then]


  [ifdef] EXTI_EXTI_IMR1_DEF
    \
    \ @brief EXTI interrupt mask register
    \ Address offset: 0x18
    \ Reset value: 0xFFC00000
    \
    $00 constant EXTI_MR0                       \ [0x00] CPU interrupt mask on configurable event input x
    $01 constant EXTI_MR1                       \ [0x01] CPU interrupt mask on configurable event input x
    $02 constant EXTI_MR2                       \ [0x02] CPU interrupt mask on configurable event input x
    $03 constant EXTI_MR3                       \ [0x03] CPU interrupt mask on configurable event input x
    $04 constant EXTI_MR4                       \ [0x04] CPU interrupt mask on configurable event input x
    $05 constant EXTI_MR5                       \ [0x05] CPU interrupt mask on configurable event input x
    $06 constant EXTI_MR6                       \ [0x06] CPU interrupt mask on configurable event input x
    $07 constant EXTI_MR7                       \ [0x07] CPU interrupt mask on configurable event input x
    $08 constant EXTI_MR8                       \ [0x08] CPU interrupt mask on configurable event input x
    $09 constant EXTI_MR9                       \ [0x09] CPU interrupt mask on configurable event input x
    $0a constant EXTI_MR10                      \ [0x0a] CPU interrupt mask on configurable event input x
    $0b constant EXTI_MR11                      \ [0x0b] CPU interrupt mask on configurable event input x
    $0c constant EXTI_MR12                      \ [0x0c] CPU interrupt mask on configurable event input x
    $0d constant EXTI_MR13                      \ [0x0d] CPU interrupt mask on configurable event input x
    $0e constant EXTI_MR14                      \ [0x0e] CPU interrupt mask on configurable event input x
    $0f constant EXTI_MR15                      \ [0x0f] CPU interrupt mask on configurable event input x
    $10 constant EXTI_MR16                      \ [0x10] CPU interrupt mask on configurable event input x
    $11 constant EXTI_MR17                      \ [0x11] CPU interrupt mask on configurable event input x
    $12 constant EXTI_MR18                      \ [0x12] CPU interrupt mask on configurable event input x
    $13 constant EXTI_MR19                      \ [0x13] CPU interrupt mask on configurable event input x
    $14 constant EXTI_MR20                      \ [0x14] CPU interrupt mask on configurable event input x
    $15 constant EXTI_MR21                      \ [0x15] CPU interrupt mask on configurable event input x
    $16 constant EXTI_MR22                      \ [0x16] CPU interrupt mask on direct event input x
    $17 constant EXTI_MR23                      \ [0x17] CPU interrupt mask on direct event input x
    $18 constant EXTI_MR24                      \ [0x18] CPU interrupt mask on direct event input x
    $19 constant EXTI_MR25                      \ [0x19] CPU interrupt mask on direct event input x
    $1a constant EXTI_MR26                      \ [0x1a] CPU interrupt mask on direct event input x
    $1b constant EXTI_MR27                      \ [0x1b] CPU interrupt mask on direct event input x
    $1c constant EXTI_MR28                      \ [0x1c] CPU interrupt mask on direct event input x
    $1d constant EXTI_MR29                      \ [0x1d] CPU interrupt mask on direct event input x
    $1e constant EXTI_MR30                      \ [0x1e] CPU interrupt mask on direct event input x
    $1f constant EXTI_MR31                      \ [0x1f] CPU interrupt mask on direct event input x
  [then]


  [ifdef] EXTI_EXTI_EMR1_DEF
    \
    \ @brief EXTI event mask register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_MR0                       \ [0x00] CPU event mask on event input x
    $01 constant EXTI_MR1                       \ [0x01] CPU event mask on event input x
    $02 constant EXTI_MR2                       \ [0x02] CPU event mask on event input x
    $03 constant EXTI_MR3                       \ [0x03] CPU event mask on event input x
    $04 constant EXTI_MR4                       \ [0x04] CPU event mask on event input x
    $05 constant EXTI_MR5                       \ [0x05] CPU event mask on event input x
    $06 constant EXTI_MR6                       \ [0x06] CPU event mask on event input x
    $07 constant EXTI_MR7                       \ [0x07] CPU event mask on event input x
    $08 constant EXTI_MR8                       \ [0x08] CPU event mask on event input x
    $09 constant EXTI_MR9                       \ [0x09] CPU event mask on event input x
    $0a constant EXTI_MR10                      \ [0x0a] CPU event mask on event input x
    $0b constant EXTI_MR11                      \ [0x0b] CPU event mask on event input x
    $0c constant EXTI_MR12                      \ [0x0c] CPU event mask on event input x
    $0d constant EXTI_MR13                      \ [0x0d] CPU event mask on event input x
    $0e constant EXTI_MR14                      \ [0x0e] CPU event mask on event input x
    $0f constant EXTI_MR15                      \ [0x0f] CPU event mask on event input x
    $10 constant EXTI_MR16                      \ [0x10] CPU event mask on event input x
    $11 constant EXTI_MR17                      \ [0x11] CPU event mask on event input x
    $12 constant EXTI_MR18                      \ [0x12] CPU event mask on event input x
    $13 constant EXTI_MR19                      \ [0x13] CPU event mask on event input x
    $14 constant EXTI_MR20                      \ [0x14] CPU event mask on event input x
    $15 constant EXTI_MR21                      \ [0x15] CPU event mask on event input x
    $16 constant EXTI_MR22                      \ [0x16] CPU event mask on event input x
    $17 constant EXTI_MR23                      \ [0x17] CPU event mask on event input x
    $18 constant EXTI_MR24                      \ [0x18] CPU event mask on event input x
    $19 constant EXTI_MR25                      \ [0x19] CPU event mask on event input x
    $1a constant EXTI_MR26                      \ [0x1a] CPU event mask on event input x
    $1b constant EXTI_MR27                      \ [0x1b] CPU event mask on event input x
    $1c constant EXTI_MR28                      \ [0x1c] CPU event mask on event input x
    $1d constant EXTI_MR29                      \ [0x1d] CPU event mask on event input x
    $1e constant EXTI_MR30                      \ [0x1e] CPU event mask on event input x
    $1f constant EXTI_MR31                      \ [0x1f] CPU event mask on event input x
  [then]


  [ifdef] EXTI_EXTI_PR1_DEF
    \
    \ @brief EXTI pending register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_PR0                       \ [0x00] Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $01 constant EXTI_PR1                       \ [0x01] Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $02 constant EXTI_PR2                       \ [0x02] Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $03 constant EXTI_PR3                       \ [0x03] Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $04 constant EXTI_PR4                       \ [0x04] Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $05 constant EXTI_PR5                       \ [0x05] Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $06 constant EXTI_PR6                       \ [0x06] Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $07 constant EXTI_PR7                       \ [0x07] Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $08 constant EXTI_PR8                       \ [0x08] Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $09 constant EXTI_PR9                       \ [0x09] Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $0a constant EXTI_PR10                      \ [0x0a] Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $0b constant EXTI_PR11                      \ [0x0b] Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $0c constant EXTI_PR12                      \ [0x0c] Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $0d constant EXTI_PR13                      \ [0x0d] Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $0e constant EXTI_PR14                      \ [0x0e] Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $0f constant EXTI_PR15                      \ [0x0f] Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $10 constant EXTI_PR16                      \ [0x10] Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $11 constant EXTI_PR17                      \ [0x11] Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $12 constant EXTI_PR18                      \ [0x12] Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $13 constant EXTI_PR19                      \ [0x13] Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $14 constant EXTI_PR20                      \ [0x14] Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $15 constant EXTI_PR21                      \ [0x15] Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
  [then]


  [ifdef] EXTI_EXTI_IMR2_DEF
    \
    \ @brief EXTI interrupt mask register
    \ Address offset: 0x24
    \ Reset value: 0xFFF5FFFF
    \
    $00 constant EXTI_MR32                      \ [0x00] CPU interrupt mask on direct event input i
    $01 constant EXTI_MR33                      \ [0x01] CPU interrupt mask on direct event input i
    $02 constant EXTI_MR34                      \ [0x02] CPU interrupt mask on direct event input i
    $03 constant EXTI_MR35                      \ [0x03] CPU interrupt mask on direct event input i
    $04 constant EXTI_MR36                      \ [0x04] CPU interrupt mask on direct event input i
    $05 constant EXTI_MR37                      \ [0x05] CPU interrupt mask on direct event input i
    $06 constant EXTI_MR38                      \ [0x06] CPU interrupt mask on direct event input i
    $07 constant EXTI_MR39                      \ [0x07] CPU interrupt mask on direct event input i
    $08 constant EXTI_MR40                      \ [0x08] CPU interrupt mask on direct event input i
    $09 constant EXTI_MR41                      \ [0x09] CPU interrupt mask on direct event input i
    $0a constant EXTI_MR42                      \ [0x0a] CPU interrupt mask on direct event input i
    $0b constant EXTI_MR43                      \ [0x0b] CPU interrupt mask on direct event input i
    $0c constant EXTI_MR44                      \ [0x0c] CPU interrupt mask on direct event input i
    $0d constant EXTI_MR45                      \ [0x0d] CPU interrupt mask on direct event input i
    $0e constant EXTI_MR46                      \ [0x0e] CPU interrupt mask on direct event input i
    $0f constant EXTI_MR47                      \ [0x0f] CPU interrupt mask on direct event input i
    $10 constant EXTI_MR48                      \ [0x10] CPU interrupt mask on direct event input i
    $11 constant EXTI_MR49                      \ [0x11] CPU interrupt mask on direct event input i
    $12 constant EXTI_MR50                      \ [0x12] CPU interrupt mask on direct event input i
    $13 constant EXTI_MR51                      \ [0x13] CPU interrupt mask on direct event input i
    $14 constant EXTI_MR52                      \ [0x14] CPU interrupt mask on direct event input i
    $15 constant EXTI_MR53                      \ [0x15] CPU interrupt mask on direct event input i
    $16 constant EXTI_MR54                      \ [0x16] CPU interrupt mask on direct event input i
    $17 constant EXTI_MR55                      \ [0x17] CPU interrupt mask on direct event input i
    $18 constant EXTI_MR56                      \ [0x18] CPU interrupt mask on direct event input i
    $19 constant EXTI_MR57                      \ [0x19] CPU interrupt mask on direct event input i
    $1a constant EXTI_MR58                      \ [0x1a] CPU interrupt mask on direct event input i
    $1b constant EXTI_MR59                      \ [0x1b] CPU interrupt mask on direct event input i
  [then]


  [ifdef] EXTI_EXTI_EMR2_DEF
    \
    \ @brief EXTI event mask register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_MR32                      \ [0x00] CPU event mask on event input i
    $01 constant EXTI_MR33                      \ [0x01] CPU event mask on event input i
    $02 constant EXTI_MR34                      \ [0x02] CPU event mask on event input i
    $03 constant EXTI_MR35                      \ [0x03] CPU event mask on event input i
    $04 constant EXTI_MR36                      \ [0x04] CPU event mask on event input i
    $05 constant EXTI_MR37                      \ [0x05] CPU event mask on event input i
    $06 constant EXTI_MR38                      \ [0x06] CPU event mask on event input i
    $07 constant EXTI_MR39                      \ [0x07] CPU event mask on event input i
    $08 constant EXTI_MR40                      \ [0x08] CPU event mask on event input i
    $09 constant EXTI_MR41                      \ [0x09] CPU event mask on event input i
    $0a constant EXTI_MR42                      \ [0x0a] CPU event mask on event input i
    $0b constant EXTI_MR43                      \ [0x0b] CPU event mask on event input i
    $0c constant EXTI_MR44                      \ [0x0c] CPU event mask on event input i
    $0d constant EXTI_MR45                      \ [0x0d] CPU event mask on event input i
    $0e constant EXTI_MR46                      \ [0x0e] CPU event mask on event input i
    $0f constant EXTI_MR47                      \ [0x0f] CPU event mask on event input i
    $10 constant EXTI_MR48                      \ [0x10] CPU event mask on event input i
    $11 constant EXTI_MR49                      \ [0x11] CPU event mask on event input i
    $12 constant EXTI_MR50                      \ [0x12] CPU event mask on event input i
    $13 constant EXTI_MR51                      \ [0x13] CPU event mask on event input i
    $14 constant EXTI_MR52                      \ [0x14] CPU event mask on event input i
    $15 constant EXTI_MR53                      \ [0x15] CPU event mask on event input i
    $16 constant EXTI_MR54                      \ [0x16] CPU event mask on event input i
    $17 constant EXTI_MR55                      \ [0x17] CPU event mask on event input i
    $18 constant EXTI_MR56                      \ [0x18] CPU event mask on event input i
    $19 constant EXTI_MR57                      \ [0x19] CPU event mask on event input i
    $1a constant EXTI_MR58                      \ [0x1a] CPU event mask on event input i
    $1b constant EXTI_MR59                      \ [0x1b] CPU event mask on event input i
  [then]


  [ifdef] EXTI_EXTI_PR2_DEF
    \
    \ @brief EXTI pending register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_PR34                      \ [0x02] Configurable event inputs x+32 Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $0e constant EXTI_PR46                      \ [0x0e] Configurable event inputs x+32 Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $11 constant EXTI_PR49                      \ [0x11] Configurable event inputs x+32 Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $13 constant EXTI_PR51                      \ [0x13] Configurable event inputs x+32 Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
    $16 constant EXTI_PR54                      \ [0x16] Configurable event inputs x+32 Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
  [then]


  [ifdef] EXTI_EXTI_IMR3_DEF
    \
    \ @brief EXTI interrupt mask register
    \ Address offset: 0x30
    \ Reset value: 0x0F8BFFFF
    \
    $0d constant EXTI_MR77                      \ [0x0d] CPU interrupt mask on direct event input x+64
  [then]


  [ifdef] EXTI_EXTI_EMR3_DEF
    \
    \ @brief EXTI event mask register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $0d constant EXTI_MR77                      \ [0x0d] CPU event mask on event input x+64
  [then]

  \
  \ @brief Extended interrupt and event controller
  \
  $00 constant EXTI_EXTI_RTSR1          \ EXTI rising trigger selection register
  $04 constant EXTI_EXTI_FTSR1          \ EXTI falling trigger selection register
  $08 constant EXTI_EXTI_SWIER1         \ EXTI software interrupt event register
  $0C constant EXTI_EXTI_RTSR2          \ EXTI rising trigger selection register
  $10 constant EXTI_EXTI_FTSR2          \ EXTI falling trigger selection register
  $14 constant EXTI_EXTI_SWIER2         \ EXTI software interrupt event register
  $18 constant EXTI_EXTI_IMR1           \ EXTI interrupt mask register
  $1C constant EXTI_EXTI_EMR1           \ EXTI event mask register
  $20 constant EXTI_EXTI_PR1            \ EXTI pending register
  $24 constant EXTI_EXTI_IMR2           \ EXTI interrupt mask register
  $28 constant EXTI_EXTI_EMR2           \ EXTI event mask register
  $2C constant EXTI_EXTI_PR2            \ EXTI pending register
  $30 constant EXTI_EXTI_IMR3           \ EXTI interrupt mask register
  $34 constant EXTI_EXTI_EMR3           \ EXTI event mask register

: EXTI_DEF ; [then]
