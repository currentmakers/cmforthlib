\
\ @file exti.fs
\ @brief EXTI address block description
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
    $00 constant EXTI_RT0                       \ [0x00] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line.
    $01 constant EXTI_RT1                       \ [0x01] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line.
    $02 constant EXTI_RT2                       \ [0x02] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line.
    $03 constant EXTI_RT3                       \ [0x03] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line.
    $04 constant EXTI_RT4                       \ [0x04] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line.
    $05 constant EXTI_RT5                       \ [0x05] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line.
    $06 constant EXTI_RT6                       \ [0x06] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line.
    $07 constant EXTI_RT7                       \ [0x07] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line.
    $08 constant EXTI_RT8                       \ [0x08] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line.
    $09 constant EXTI_RT9                       \ [0x09] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line.
    $0a constant EXTI_RT10                      \ [0x0a] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line.
    $0b constant EXTI_RT11                      \ [0x0b] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line.
    $0c constant EXTI_RT12                      \ [0x0c] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line.
    $0d constant EXTI_RT13                      \ [0x0d] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line.
    $0e constant EXTI_RT14                      \ [0x0e] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line.
    $0f constant EXTI_RT15                      \ [0x0f] Rising trigger event configuration bit of configurable line x (x = 15 to 0) Each bit enables/disables the rising edge trigger for the event and interrupt on the corresponding line.
  [then]


  [ifdef] EXTI_EXTI_FTSR1_DEF
    \
    \ @brief EXTI falling trigger selection register 1
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_FT0                       \ [0x00] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line.
    $01 constant EXTI_FT1                       \ [0x01] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line.
    $02 constant EXTI_FT2                       \ [0x02] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line.
    $03 constant EXTI_FT3                       \ [0x03] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line.
    $04 constant EXTI_FT4                       \ [0x04] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line.
    $05 constant EXTI_FT5                       \ [0x05] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line.
    $06 constant EXTI_FT6                       \ [0x06] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line.
    $07 constant EXTI_FT7                       \ [0x07] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line.
    $08 constant EXTI_FT8                       \ [0x08] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line.
    $09 constant EXTI_FT9                       \ [0x09] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line.
    $0a constant EXTI_FT10                      \ [0x0a] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line.
    $0b constant EXTI_FT11                      \ [0x0b] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line.
    $0c constant EXTI_FT12                      \ [0x0c] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line.
    $0d constant EXTI_FT13                      \ [0x0d] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line.
    $0e constant EXTI_FT14                      \ [0x0e] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line.
    $0f constant EXTI_FT15                      \ [0x0f] Falling trigger event configuration bit of configurable line x (x = 15 to 0). Each bit enables/disables the falling edge trigger for the event and interrupt on the corresponding line.
  [then]


  [ifdef] EXTI_EXTI_SWIER1_DEF
    \
    \ @brief EXTI software interrupt event register 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_SWI0                      \ [0x00] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $01 constant EXTI_SWI1                      \ [0x01] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $02 constant EXTI_SWI2                      \ [0x02] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $03 constant EXTI_SWI3                      \ [0x03] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $04 constant EXTI_SWI4                      \ [0x04] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $05 constant EXTI_SWI5                      \ [0x05] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $06 constant EXTI_SWI6                      \ [0x06] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $07 constant EXTI_SWI7                      \ [0x07] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $08 constant EXTI_SWI8                      \ [0x08] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $09 constant EXTI_SWI9                      \ [0x09] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $0a constant EXTI_SWI10                     \ [0x0a] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $0b constant EXTI_SWI11                     \ [0x0b] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $0c constant EXTI_SWI12                     \ [0x0c] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $0d constant EXTI_SWI13                     \ [0x0d] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $0e constant EXTI_SWI14                     \ [0x0e] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
    $0f constant EXTI_SWI15                     \ [0x0f] Software rising edge event trigger on line x (x = 15 to 0) Setting of any bit by software triggers a rising edge event on the corresponding line x, resulting in an interrupt, independently of EXTI_RTSR1 and EXTI_FTSR1 settings. The bits are automatically cleared by HW. Reading of any bit always returns 0.
  [then]


  [ifdef] EXTI_EXTI_RPR1_DEF
    \
    \ @brief EXTI rising edge pending register 1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_RPIF0                     \ [0x00] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $01 constant EXTI_RPIF1                     \ [0x01] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $02 constant EXTI_RPIF2                     \ [0x02] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $03 constant EXTI_RPIF3                     \ [0x03] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $04 constant EXTI_RPIF4                     \ [0x04] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $05 constant EXTI_RPIF5                     \ [0x05] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $06 constant EXTI_RPIF6                     \ [0x06] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $07 constant EXTI_RPIF7                     \ [0x07] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $08 constant EXTI_RPIF8                     \ [0x08] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $09 constant EXTI_RPIF9                     \ [0x09] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0a constant EXTI_RPIF10                    \ [0x0a] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0b constant EXTI_RPIF11                    \ [0x0b] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0c constant EXTI_RPIF12                    \ [0x0c] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0d constant EXTI_RPIF13                    \ [0x0d] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0e constant EXTI_RPIF14                    \ [0x0e] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0f constant EXTI_RPIF15                    \ [0x0f] Rising edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a rising edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
  [then]


  [ifdef] EXTI_EXTI_FPR1_DEF
    \
    \ @brief EXTI falling edge pending register 1
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_FPIF0                     \ [0x00] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $01 constant EXTI_FPIF1                     \ [0x01] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $02 constant EXTI_FPIF2                     \ [0x02] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $03 constant EXTI_FPIF3                     \ [0x03] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $04 constant EXTI_FPIF4                     \ [0x04] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $05 constant EXTI_FPIF5                     \ [0x05] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $06 constant EXTI_FPIF6                     \ [0x06] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $07 constant EXTI_FPIF7                     \ [0x07] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $08 constant EXTI_FPIF8                     \ [0x08] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $09 constant EXTI_FPIF9                     \ [0x09] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0a constant EXTI_FPIF10                    \ [0x0a] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0b constant EXTI_FPIF11                    \ [0x0b] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0c constant EXTI_FPIF12                    \ [0x0c] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0d constant EXTI_FPIF13                    \ [0x0d] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0e constant EXTI_FPIF14                    \ [0x0e] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
    $0f constant EXTI_FPIF15                    \ [0x0f] Falling edge event pending for configurable line x (x = 15 to 0) Each bit is set upon a falling edge event generated by hardware or by software (through the EXTI_SWIER1 register) on the corresponding line. Each bit is cleared by writing 1 into it.
  [then]


  [ifdef] EXTI_EXTI_EXTICR1_DEF
    \
    \ @brief EXTI external interrupt selection register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI0                     \ [0x00 : 8] EXTIm GPIO port selection (m = 4 * (x - 1)) These bits are written by software to select the source input for EXTIm external interrupt. Other: reserved
    $08 constant EXTI_EXTI1                     \ [0x08 : 8] EXTI1
    $10 constant EXTI_EXTI2                     \ [0x10 : 8] EXTI2
    $18 constant EXTI_EXTI3                     \ [0x18 : 8] EXTI3
  [then]


  [ifdef] EXTI_EXTI_EXTICR2_DEF
    \
    \ @brief EXTI external interrupt selection register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI0                     \ [0x00 : 8] EXTIm GPIO port selection (m = 4 * (x - 1)) These bits are written by software to select the source input for EXTIm external interrupt. Other: reserved
    $08 constant EXTI_EXTI1                     \ [0x08 : 8] EXTI1
    $10 constant EXTI_EXTI2                     \ [0x10 : 8] EXTI2
    $18 constant EXTI_EXTI3                     \ [0x18 : 8] EXTI3
  [then]


  [ifdef] EXTI_EXTI_EXTICR3_DEF
    \
    \ @brief EXTI external interrupt selection register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI0                     \ [0x00 : 8] EXTIm GPIO port selection (m = 4 * (x - 1)) These bits are written by software to select the source input for EXTIm external interrupt. Other: reserved
    $08 constant EXTI_EXTI1                     \ [0x08 : 8] EXTI1
    $10 constant EXTI_EXTI2                     \ [0x10 : 8] EXTI2
    $18 constant EXTI_EXTI3                     \ [0x18 : 8] EXTI3
  [then]


  [ifdef] EXTI_EXTI_EXTICR4_DEF
    \
    \ @brief EXTI external interrupt selection register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI0                     \ [0x00 : 8] EXTIm GPIO port selection (m = 4 * (x - 1)) These bits are written by software to select the source input for EXTIm external interrupt. Other: reserved
    $08 constant EXTI_EXTI1                     \ [0x08 : 8] EXTI1
    $10 constant EXTI_EXTI2                     \ [0x10 : 8] EXTI2
    $18 constant EXTI_EXTI3                     \ [0x18 : 8] EXTI3
  [then]


  [ifdef] EXTI_EXTI_IMR1_DEF
    \
    \ @brief EXTI CPU wakeup with interrupt mask register
    \ Address offset: 0x80
    \ Reset value: 0xFFF80000
    \
    $00 constant EXTI_IM                        \ [0x00 : 16] CPU wakeup with interrupt mask
    $13 constant EXTI_IM19                      \ [0x13] IM19
    $17 constant EXTI_IM23                      \ [0x17] IM23
    $19 constant EXTI_IM25                      \ [0x19] IM25
    $1f constant EXTI_IM31                      \ [0x1f] IM31
  [then]


  [ifdef] EXTI_EXTI_EMR1_DEF
    \
    \ @brief EXTI CPU wakeup with event mask register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EM                        \ [0x00 : 16] CPU wakeup with event generation mask
    $13 constant EXTI_EM19                      \ [0x13] EM19
    $17 constant EXTI_EM23                      \ [0x17] EM23
    $19 constant EXTI_EM25                      \ [0x19] EM25
    $1f constant EXTI_EM31                      \ [0x1f] EM31
  [then]

  \
  \ @brief EXTI address block description
  \
  $00 constant EXTI_EXTI_RTSR1          \ EXTI rising trigger selection register
  $04 constant EXTI_EXTI_FTSR1          \ EXTI falling trigger selection register 1
  $08 constant EXTI_EXTI_SWIER1         \ EXTI software interrupt event register 1
  $0C constant EXTI_EXTI_RPR1           \ EXTI rising edge pending register 1
  $10 constant EXTI_EXTI_FPR1           \ EXTI falling edge pending register 1
  $60 constant EXTI_EXTI_EXTICR1        \ EXTI external interrupt selection register
  $64 constant EXTI_EXTI_EXTICR2        \ EXTI external interrupt selection register
  $68 constant EXTI_EXTI_EXTICR3        \ EXTI external interrupt selection register
  $6C constant EXTI_EXTI_EXTICR4        \ EXTI external interrupt selection register
  $80 constant EXTI_EXTI_IMR1           \ EXTI CPU wakeup with interrupt mask register
  $84 constant EXTI_EXTI_EMR1           \ EXTI CPU wakeup with event mask register

: EXTI_DEF ; [then]
