\
\ @file gpioa.fs
\ @brief GPIOA address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief GPIO port mode register
\ Address offset: 0x00
\ Reset value: 0x00FFFFFF
\

$00000003 constant GPIOA_GPIOA_MODER_MODE0                          \ Port x configuration I/O pin y
$0000000c constant GPIOA_GPIOA_MODER_MODE1                          \ Port x configuration I/O pin y
$00000030 constant GPIOA_GPIOA_MODER_MODE2                          \ Port x configuration I/O pin y
$000000c0 constant GPIOA_GPIOA_MODER_MODE3                          \ Port x configuration I/O pin y
$00000300 constant GPIOA_GPIOA_MODER_MODE4                          \ Port x configuration I/O pin y
$00000c00 constant GPIOA_GPIOA_MODER_MODE5                          \ Port x configuration I/O pin y
$00003000 constant GPIOA_GPIOA_MODER_MODE6                          \ Port x configuration I/O pin y
$0000c000 constant GPIOA_GPIOA_MODER_MODE7                          \ Port x configuration I/O pin y
$00030000 constant GPIOA_GPIOA_MODER_MODE8                          \ Port x configuration I/O pin y
$000c0000 constant GPIOA_GPIOA_MODER_MODE9                          \ Port x configuration I/O pin y
$00300000 constant GPIOA_GPIOA_MODER_MODE10                         \ Port x configuration I/O pin y
$00c00000 constant GPIOA_GPIOA_MODER_MODE11                         \ Port x configuration I/O pin y
$03000000 constant GPIOA_GPIOA_MODER_MODE12                         \ Port x configuration I/O pin y
$0c000000 constant GPIOA_GPIOA_MODER_MODE13                         \ Port x configuration I/O pin y
$30000000 constant GPIOA_GPIOA_MODER_MODE14                         \ Port x configuration I/O pin y
$c0000000 constant GPIOA_GPIOA_MODER_MODE15                         \ Port x configuration I/O pin y


\
\ @brief GPIO port output type register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_GPIOA_OTYPER_OT0                           \ Port x configuration I/O pin y
$00000002 constant GPIOA_GPIOA_OTYPER_OT1                           \ Port x configuration I/O pin y
$00000004 constant GPIOA_GPIOA_OTYPER_OT2                           \ Port x configuration I/O pin y
$00000008 constant GPIOA_GPIOA_OTYPER_OT3                           \ Port x configuration I/O pin y
$00000010 constant GPIOA_GPIOA_OTYPER_OT4                           \ Port x configuration I/O pin y
$00000020 constant GPIOA_GPIOA_OTYPER_OT5                           \ Port x configuration I/O pin y
$00000040 constant GPIOA_GPIOA_OTYPER_OT6                           \ Port x configuration I/O pin y
$00000080 constant GPIOA_GPIOA_OTYPER_OT7                           \ Port x configuration I/O pin y
$00000100 constant GPIOA_GPIOA_OTYPER_OT8                           \ Port x configuration I/O pin y
$00000200 constant GPIOA_GPIOA_OTYPER_OT9                           \ Port x configuration I/O pin y
$00000400 constant GPIOA_GPIOA_OTYPER_OT10                          \ Port x configuration I/O pin y
$00000800 constant GPIOA_GPIOA_OTYPER_OT11                          \ Port x configuration I/O pin y
$00001000 constant GPIOA_GPIOA_OTYPER_OT12                          \ Port x configuration I/O pin y
$00002000 constant GPIOA_GPIOA_OTYPER_OT13                          \ Port x configuration I/O pin y
$00004000 constant GPIOA_GPIOA_OTYPER_OT14                          \ Port x configuration I/O pin y
$00008000 constant GPIOA_GPIOA_OTYPER_OT15                          \ Port x configuration I/O pin y


\
\ @brief GPIO port output speed register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000003 constant GPIOA_GPIOA_OSPEEDR_OSPEED0                      \ Port x configuration I/O pin y
$0000000c constant GPIOA_GPIOA_OSPEEDR_OSPEED1                      \ Port x configuration I/O pin y
$00000030 constant GPIOA_GPIOA_OSPEEDR_OSPEED2                      \ Port x configuration I/O pin y
$000000c0 constant GPIOA_GPIOA_OSPEEDR_OSPEED3                      \ Port x configuration I/O pin y
$00000300 constant GPIOA_GPIOA_OSPEEDR_OSPEED4                      \ Port x configuration I/O pin y
$00000c00 constant GPIOA_GPIOA_OSPEEDR_OSPEED5                      \ Port x configuration I/O pin y
$00003000 constant GPIOA_GPIOA_OSPEEDR_OSPEED6                      \ Port x configuration I/O pin y
$0000c000 constant GPIOA_GPIOA_OSPEEDR_OSPEED7                      \ Port x configuration I/O pin y
$00030000 constant GPIOA_GPIOA_OSPEEDR_OSPEED8                      \ Port x configuration I/O pin y
$000c0000 constant GPIOA_GPIOA_OSPEEDR_OSPEED9                      \ Port x configuration I/O pin y
$00300000 constant GPIOA_GPIOA_OSPEEDR_OSPEED10                     \ Port x configuration I/O pin y
$00c00000 constant GPIOA_GPIOA_OSPEEDR_OSPEED11                     \ Port x configuration I/O pin y
$03000000 constant GPIOA_GPIOA_OSPEEDR_OSPEED12                     \ Port x configuration I/O pin y
$0c000000 constant GPIOA_GPIOA_OSPEEDR_OSPEED13                     \ Port x configuration I/O pin y
$30000000 constant GPIOA_GPIOA_OSPEEDR_OSPEED14                     \ Port x configuration I/O pin y
$c0000000 constant GPIOA_GPIOA_OSPEEDR_OSPEED15                     \ Port x configuration I/O pin y


\
\ @brief GPIO port pull-up/pull-down register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000003 constant GPIOA_GPIOA_PUPDR_PUPD0                          \ Port x configuration I/O pin y
$0000000c constant GPIOA_GPIOA_PUPDR_PUPD1                          \ Port x configuration I/O pin y
$00000030 constant GPIOA_GPIOA_PUPDR_PUPD2                          \ Port x configuration I/O pin y
$000000c0 constant GPIOA_GPIOA_PUPDR_PUPD3                          \ Port x configuration I/O pin y
$00000300 constant GPIOA_GPIOA_PUPDR_PUPD4                          \ Port x configuration I/O pin y
$00000c00 constant GPIOA_GPIOA_PUPDR_PUPD5                          \ Port x configuration I/O pin y
$00003000 constant GPIOA_GPIOA_PUPDR_PUPD6                          \ Port x configuration I/O pin y
$0000c000 constant GPIOA_GPIOA_PUPDR_PUPD7                          \ Port x configuration I/O pin y
$00030000 constant GPIOA_GPIOA_PUPDR_PUPD8                          \ Port x configuration I/O pin y
$000c0000 constant GPIOA_GPIOA_PUPDR_PUPD9                          \ Port x configuration I/O pin y
$00300000 constant GPIOA_GPIOA_PUPDR_PUPD10                         \ Port x configuration I/O pin y
$00c00000 constant GPIOA_GPIOA_PUPDR_PUPD11                         \ Port x configuration I/O pin y
$03000000 constant GPIOA_GPIOA_PUPDR_PUPD12                         \ Port x configuration I/O pin y
$0c000000 constant GPIOA_GPIOA_PUPDR_PUPD13                         \ Port x configuration I/O pin y
$30000000 constant GPIOA_GPIOA_PUPDR_PUPD14                         \ Port x configuration I/O pin y
$c0000000 constant GPIOA_GPIOA_PUPDR_PUPD15                         \ Port x configuration I/O pin y


\
\ @brief GPIO port input data register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_GPIOA_IDR_ID0                              \ Port x input data I/O pin y
$00000002 constant GPIOA_GPIOA_IDR_ID1                              \ Port x input data I/O pin y
$00000004 constant GPIOA_GPIOA_IDR_ID2                              \ Port x input data I/O pin y
$00000008 constant GPIOA_GPIOA_IDR_ID3                              \ Port x input data I/O pin y
$00000010 constant GPIOA_GPIOA_IDR_ID4                              \ Port x input data I/O pin y
$00000020 constant GPIOA_GPIOA_IDR_ID5                              \ Port x input data I/O pin y
$00000040 constant GPIOA_GPIOA_IDR_ID6                              \ Port x input data I/O pin y
$00000080 constant GPIOA_GPIOA_IDR_ID7                              \ Port x input data I/O pin y
$00000100 constant GPIOA_GPIOA_IDR_ID8                              \ Port x input data I/O pin y
$00000200 constant GPIOA_GPIOA_IDR_ID9                              \ Port x input data I/O pin y
$00000400 constant GPIOA_GPIOA_IDR_ID10                             \ Port x input data I/O pin y
$00000800 constant GPIOA_GPIOA_IDR_ID11                             \ Port x input data I/O pin y
$00001000 constant GPIOA_GPIOA_IDR_ID12                             \ Port x input data I/O pin y
$00002000 constant GPIOA_GPIOA_IDR_ID13                             \ Port x input data I/O pin y
$00004000 constant GPIOA_GPIOA_IDR_ID14                             \ Port x input data I/O pin y
$00008000 constant GPIOA_GPIOA_IDR_ID15                             \ Port x input data I/O pin y


\
\ @brief GPIO port output data register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_GPIOA_ODR_OD0                              \ Port output data I/O pin y
$00000002 constant GPIOA_GPIOA_ODR_OD1                              \ Port output data I/O pin y
$00000004 constant GPIOA_GPIOA_ODR_OD2                              \ Port output data I/O pin y
$00000008 constant GPIOA_GPIOA_ODR_OD3                              \ Port output data I/O pin y
$00000010 constant GPIOA_GPIOA_ODR_OD4                              \ Port output data I/O pin y
$00000020 constant GPIOA_GPIOA_ODR_OD5                              \ Port output data I/O pin y
$00000040 constant GPIOA_GPIOA_ODR_OD6                              \ Port output data I/O pin y
$00000080 constant GPIOA_GPIOA_ODR_OD7                              \ Port output data I/O pin y
$00000100 constant GPIOA_GPIOA_ODR_OD8                              \ Port output data I/O pin y
$00000200 constant GPIOA_GPIOA_ODR_OD9                              \ Port output data I/O pin y
$00000400 constant GPIOA_GPIOA_ODR_OD10                             \ Port output data I/O pin y
$00000800 constant GPIOA_GPIOA_ODR_OD11                             \ Port output data I/O pin y
$00001000 constant GPIOA_GPIOA_ODR_OD12                             \ Port output data I/O pin y
$00002000 constant GPIOA_GPIOA_ODR_OD13                             \ Port output data I/O pin y
$00004000 constant GPIOA_GPIOA_ODR_OD14                             \ Port output data I/O pin y
$00008000 constant GPIOA_GPIOA_ODR_OD15                             \ Port output data I/O pin y


\
\ @brief GPIO port bit set/reset register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_GPIOA_BSRR_BS0                             \ Port x set I/O pin y
$00000002 constant GPIOA_GPIOA_BSRR_BS1                             \ Port x set I/O pin y
$00000004 constant GPIOA_GPIOA_BSRR_BS2                             \ Port x set I/O pin y
$00000008 constant GPIOA_GPIOA_BSRR_BS3                             \ Port x set I/O pin y
$00000010 constant GPIOA_GPIOA_BSRR_BS4                             \ Port x set I/O pin y
$00000020 constant GPIOA_GPIOA_BSRR_BS5                             \ Port x set I/O pin y
$00000040 constant GPIOA_GPIOA_BSRR_BS6                             \ Port x set I/O pin y
$00000080 constant GPIOA_GPIOA_BSRR_BS7                             \ Port x set I/O pin y
$00000100 constant GPIOA_GPIOA_BSRR_BS8                             \ Port x set I/O pin y
$00000200 constant GPIOA_GPIOA_BSRR_BS9                             \ Port x set I/O pin y
$00000400 constant GPIOA_GPIOA_BSRR_BS10                            \ Port x set I/O pin y
$00000800 constant GPIOA_GPIOA_BSRR_BS11                            \ Port x set I/O pin y
$00001000 constant GPIOA_GPIOA_BSRR_BS12                            \ Port x set I/O pin y
$00002000 constant GPIOA_GPIOA_BSRR_BS13                            \ Port x set I/O pin y
$00004000 constant GPIOA_GPIOA_BSRR_BS14                            \ Port x set I/O pin y
$00008000 constant GPIOA_GPIOA_BSRR_BS15                            \ Port x set I/O pin y
$00010000 constant GPIOA_GPIOA_BSRR_BR0                             \ Port x reset I/O pin y
$00020000 constant GPIOA_GPIOA_BSRR_BR1                             \ Port x reset I/O pin y
$00040000 constant GPIOA_GPIOA_BSRR_BR2                             \ Port x reset I/O pin y
$00080000 constant GPIOA_GPIOA_BSRR_BR3                             \ Port x reset I/O pin y
$00100000 constant GPIOA_GPIOA_BSRR_BR4                             \ Port x reset I/O pin y
$00200000 constant GPIOA_GPIOA_BSRR_BR5                             \ Port x reset I/O pin y
$00400000 constant GPIOA_GPIOA_BSRR_BR6                             \ Port x reset I/O pin y
$00800000 constant GPIOA_GPIOA_BSRR_BR7                             \ Port x reset I/O pin y
$01000000 constant GPIOA_GPIOA_BSRR_BR8                             \ Port x reset I/O pin y
$02000000 constant GPIOA_GPIOA_BSRR_BR9                             \ Port x reset I/O pin y
$04000000 constant GPIOA_GPIOA_BSRR_BR10                            \ Port x reset I/O pin y
$08000000 constant GPIOA_GPIOA_BSRR_BR11                            \ Port x reset I/O pin y
$10000000 constant GPIOA_GPIOA_BSRR_BR12                            \ Port x reset I/O pin y
$20000000 constant GPIOA_GPIOA_BSRR_BR13                            \ Port x reset I/O pin y
$40000000 constant GPIOA_GPIOA_BSRR_BR14                            \ Port x reset I/O pin y
$80000000 constant GPIOA_GPIOA_BSRR_BR15                            \ Port x reset I/O pin y


\
\ @brief GPIO port configuration lock register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_GPIOA_LCKR_LCK0                            \ Port x lock I/O pin y
$00000002 constant GPIOA_GPIOA_LCKR_LCK1                            \ Port x lock I/O pin y
$00000004 constant GPIOA_GPIOA_LCKR_LCK2                            \ Port x lock I/O pin y
$00000008 constant GPIOA_GPIOA_LCKR_LCK3                            \ Port x lock I/O pin y
$00000010 constant GPIOA_GPIOA_LCKR_LCK4                            \ Port x lock I/O pin y
$00000020 constant GPIOA_GPIOA_LCKR_LCK5                            \ Port x lock I/O pin y
$00000040 constant GPIOA_GPIOA_LCKR_LCK6                            \ Port x lock I/O pin y
$00000080 constant GPIOA_GPIOA_LCKR_LCK7                            \ Port x lock I/O pin y
$00000100 constant GPIOA_GPIOA_LCKR_LCK8                            \ Port x lock I/O pin y
$00000200 constant GPIOA_GPIOA_LCKR_LCK9                            \ Port x lock I/O pin y
$00000400 constant GPIOA_GPIOA_LCKR_LCK10                           \ Port x lock I/O pin y
$00000800 constant GPIOA_GPIOA_LCKR_LCK11                           \ Port x lock I/O pin y
$00001000 constant GPIOA_GPIOA_LCKR_LCK12                           \ Port x lock I/O pin y
$00002000 constant GPIOA_GPIOA_LCKR_LCK13                           \ Port x lock I/O pin y
$00004000 constant GPIOA_GPIOA_LCKR_LCK14                           \ Port x lock I/O pin y
$00008000 constant GPIOA_GPIOA_LCKR_LCK15                           \ Port x lock I/O pin y
$00010000 constant GPIOA_GPIOA_LCKR_LCKK                            \ Lock key


\
\ @brief GPIO alternate function low register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant GPIOA_GPIOA_AFRL_AFSEL0                          \ Alternate function selection for port x I/O pin y
$000000f0 constant GPIOA_GPIOA_AFRL_AFSEL1                          \ Alternate function selection for port x I/O pin y
$00000f00 constant GPIOA_GPIOA_AFRL_AFSEL2                          \ Alternate function selection for port x I/O pin y
$0000f000 constant GPIOA_GPIOA_AFRL_AFSEL3                          \ Alternate function selection for port x I/O pin y
$000f0000 constant GPIOA_GPIOA_AFRL_AFSEL4                          \ Alternate function selection for port x I/O pin y
$00f00000 constant GPIOA_GPIOA_AFRL_AFSEL5                          \ Alternate function selection for port x I/O pin y
$0f000000 constant GPIOA_GPIOA_AFRL_AFSEL6                          \ Alternate function selection for port x I/O pin y
$f0000000 constant GPIOA_GPIOA_AFRL_AFSEL7                          \ Alternate function selection for port x I/O pin y


\
\ @brief GPIO alternate function high register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000000f constant GPIOA_GPIOA_AFRH_AFSEL8                          \ Alternate function selection for port x I/O pin y
$000000f0 constant GPIOA_GPIOA_AFRH_AFSEL9                          \ Alternate function selection for port x I/O pin y
$00000f00 constant GPIOA_GPIOA_AFRH_AFSEL10                         \ Alternate function selection for port x I/O pin y
$0000f000 constant GPIOA_GPIOA_AFRH_AFSEL11                         \ Alternate function selection for port x I/O pin y
$000f0000 constant GPIOA_GPIOA_AFRH_AFSEL12                         \ Alternate function selection for port x I/O pin y
$00f00000 constant GPIOA_GPIOA_AFRH_AFSEL13                         \ Alternate function selection for port x I/O pin y
$0f000000 constant GPIOA_GPIOA_AFRH_AFSEL14                         \ Alternate function selection for port x I/O pin y
$f0000000 constant GPIOA_GPIOA_AFRH_AFSEL15                         \ Alternate function selection for port x I/O pin y


\
\ @brief GPIO port bit reset register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_GPIOA_BRR_BR0                              \ Port x reset IO pin y
$00000002 constant GPIOA_GPIOA_BRR_BR1                              \ Port x reset IO pin y
$00000004 constant GPIOA_GPIOA_BRR_BR2                              \ Port x reset IO pin y
$00000008 constant GPIOA_GPIOA_BRR_BR3                              \ Port x reset IO pin y
$00000010 constant GPIOA_GPIOA_BRR_BR4                              \ Port x reset IO pin y
$00000020 constant GPIOA_GPIOA_BRR_BR5                              \ Port x reset IO pin y
$00000040 constant GPIOA_GPIOA_BRR_BR6                              \ Port x reset IO pin y
$00000080 constant GPIOA_GPIOA_BRR_BR7                              \ Port x reset IO pin y
$00000100 constant GPIOA_GPIOA_BRR_BR8                              \ Port x reset IO pin y
$00000200 constant GPIOA_GPIOA_BRR_BR9                              \ Port x reset IO pin y
$00000400 constant GPIOA_GPIOA_BRR_BR10                             \ Port x reset IO pin y
$00000800 constant GPIOA_GPIOA_BRR_BR11                             \ Port x reset IO pin y
$00001000 constant GPIOA_GPIOA_BRR_BR12                             \ Port x reset IO pin y
$00002000 constant GPIOA_GPIOA_BRR_BR13                             \ Port x reset IO pin y
$00004000 constant GPIOA_GPIOA_BRR_BR14                             \ Port x reset IO pin y
$00008000 constant GPIOA_GPIOA_BRR_BR15                             \ Port x reset IO pin y


\
\ @brief GPIO high-speed low-voltage register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_GPIOA_HSLVR_HSLV0                          \ Port x high-speed low-voltage configuration
$00000002 constant GPIOA_GPIOA_HSLVR_HSLV1                          \ Port x high-speed low-voltage configuration
$00000004 constant GPIOA_GPIOA_HSLVR_HSLV2                          \ Port x high-speed low-voltage configuration
$00000008 constant GPIOA_GPIOA_HSLVR_HSLV3                          \ Port x high-speed low-voltage configuration
$00000010 constant GPIOA_GPIOA_HSLVR_HSLV4                          \ Port x high-speed low-voltage configuration
$00000020 constant GPIOA_GPIOA_HSLVR_HSLV5                          \ Port x high-speed low-voltage configuration
$00000040 constant GPIOA_GPIOA_HSLVR_HSLV6                          \ Port x high-speed low-voltage configuration
$00000080 constant GPIOA_GPIOA_HSLVR_HSLV7                          \ Port x high-speed low-voltage configuration
$00000100 constant GPIOA_GPIOA_HSLVR_HSLV8                          \ Port x high-speed low-voltage configuration
$00000200 constant GPIOA_GPIOA_HSLVR_HSLV9                          \ Port x high-speed low-voltage configuration
$00000400 constant GPIOA_GPIOA_HSLVR_HSLV10                         \ Port x high-speed low-voltage configuration
$00000800 constant GPIOA_GPIOA_HSLVR_HSLV11                         \ Port x high-speed low-voltage configuration
$00001000 constant GPIOA_GPIOA_HSLVR_HSLV12                         \ Port x high-speed low-voltage configuration
$00002000 constant GPIOA_GPIOA_HSLVR_HSLV13                         \ Port x high-speed low-voltage configuration
$00004000 constant GPIOA_GPIOA_HSLVR_HSLV14                         \ Port x high-speed low-voltage configuration
$00008000 constant GPIOA_GPIOA_HSLVR_HSLV15                         \ Port x high-speed low-voltage configuration


\
\ @brief GPIO secure configuration register
\ Address offset: 0x30
\ Reset value: 0x00000FFF
\

$00000001 constant GPIOA_GPIOA_SECCFGR_SEC0                         \ I/O pin of Port x secure bit enable y
$00000002 constant GPIOA_GPIOA_SECCFGR_SEC1                         \ I/O pin of Port x secure bit enable y
$00000004 constant GPIOA_GPIOA_SECCFGR_SEC2                         \ I/O pin of Port x secure bit enable y
$00000008 constant GPIOA_GPIOA_SECCFGR_SEC3                         \ I/O pin of Port x secure bit enable y
$00000010 constant GPIOA_GPIOA_SECCFGR_SEC4                         \ I/O pin of Port x secure bit enable y
$00000020 constant GPIOA_GPIOA_SECCFGR_SEC5                         \ I/O pin of Port x secure bit enable y
$00000040 constant GPIOA_GPIOA_SECCFGR_SEC6                         \ I/O pin of Port x secure bit enable y
$00000080 constant GPIOA_GPIOA_SECCFGR_SEC7                         \ I/O pin of Port x secure bit enable y
$00000100 constant GPIOA_GPIOA_SECCFGR_SEC8                         \ I/O pin of Port x secure bit enable y
$00000200 constant GPIOA_GPIOA_SECCFGR_SEC9                         \ I/O pin of Port x secure bit enable y
$00000400 constant GPIOA_GPIOA_SECCFGR_SEC10                        \ I/O pin of Port x secure bit enable y
$00000800 constant GPIOA_GPIOA_SECCFGR_SEC11                        \ I/O pin of Port x secure bit enable y
$00001000 constant GPIOA_GPIOA_SECCFGR_SEC12                        \ I/O pin of Port x secure bit enable y
$00002000 constant GPIOA_GPIOA_SECCFGR_SEC13                        \ I/O pin of Port x secure bit enable y
$00004000 constant GPIOA_GPIOA_SECCFGR_SEC14                        \ I/O pin of Port x secure bit enable y
$00008000 constant GPIOA_GPIOA_SECCFGR_SEC15                        \ I/O pin of Port x secure bit enable y


\
\ @brief GPIOA address block description
\
$42020000 constant GPIOA_GPIOA_MODER  \ offset: 0x00 : GPIO port mode register
$42020004 constant GPIOA_GPIOA_OTYPER  \ offset: 0x04 : GPIO port output type register
$42020008 constant GPIOA_GPIOA_OSPEEDR  \ offset: 0x08 : GPIO port output speed register
$4202000c constant GPIOA_GPIOA_PUPDR  \ offset: 0x0C : GPIO port pull-up/pull-down register
$42020010 constant GPIOA_GPIOA_IDR  \ offset: 0x10 : GPIO port input data register
$42020014 constant GPIOA_GPIOA_ODR  \ offset: 0x14 : GPIO port output data register
$42020018 constant GPIOA_GPIOA_BSRR  \ offset: 0x18 : GPIO port bit set/reset register
$4202001c constant GPIOA_GPIOA_LCKR  \ offset: 0x1C : GPIO port configuration lock register
$42020020 constant GPIOA_GPIOA_AFRL  \ offset: 0x20 : GPIO alternate function low register
$42020024 constant GPIOA_GPIOA_AFRH  \ offset: 0x24 : GPIO alternate function high register
$42020028 constant GPIOA_GPIOA_BRR  \ offset: 0x28 : GPIO port bit reset register
$4202002c constant GPIOA_GPIOA_HSLVR  \ offset: 0x2C : GPIO high-speed low-voltage register
$42020030 constant GPIOA_GPIOA_SECCFGR  \ offset: 0x30 : GPIO secure configuration register

