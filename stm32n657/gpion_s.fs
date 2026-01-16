\
\ @file gpion_s.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief GPIO port N mode register
\ Address offset: 0x00
\ Reset value: 0xFFFFFFFF
\

$00000003 constant GPION_S_GPION_MODER_MODE0                        \ Port x configuration I/O pin y
$0000000c constant GPION_S_GPION_MODER_MODE1                        \ Port x configuration I/O pin y
$00000030 constant GPION_S_GPION_MODER_MODE2                        \ Port x configuration I/O pin y
$000000c0 constant GPION_S_GPION_MODER_MODE3                        \ Port x configuration I/O pin y
$00000300 constant GPION_S_GPION_MODER_MODE4                        \ Port x configuration I/O pin y
$00000c00 constant GPION_S_GPION_MODER_MODE5                        \ Port x configuration I/O pin y
$00003000 constant GPION_S_GPION_MODER_MODE6                        \ Port x configuration I/O pin y
$0000c000 constant GPION_S_GPION_MODER_MODE7                        \ Port x configuration I/O pin y
$00030000 constant GPION_S_GPION_MODER_MODE8                        \ Port x configuration I/O pin y
$000c0000 constant GPION_S_GPION_MODER_MODE9                        \ Port x configuration I/O pin y
$00300000 constant GPION_S_GPION_MODER_MODE10                       \ Port x configuration I/O pin y
$00c00000 constant GPION_S_GPION_MODER_MODE11                       \ Port x configuration I/O pin y
$03000000 constant GPION_S_GPION_MODER_MODE12                       \ Port x configuration I/O pin y
$0c000000 constant GPION_S_GPION_MODER_MODE13                       \ Port x configuration I/O pin y
$30000000 constant GPION_S_GPION_MODER_MODE14                       \ Port x configuration I/O pin y
$c0000000 constant GPION_S_GPION_MODER_MODE15                       \ Port x configuration I/O pin y


\
\ @brief GPIO port N output type register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant GPION_S_GPION_OTYPER_OT0                         \ Port x configuration I/O pin y
$00000002 constant GPION_S_GPION_OTYPER_OT1                         \ Port x configuration I/O pin y
$00000004 constant GPION_S_GPION_OTYPER_OT2                         \ Port x configuration I/O pin y
$00000008 constant GPION_S_GPION_OTYPER_OT3                         \ Port x configuration I/O pin y
$00000010 constant GPION_S_GPION_OTYPER_OT4                         \ Port x configuration I/O pin y
$00000020 constant GPION_S_GPION_OTYPER_OT5                         \ Port x configuration I/O pin y
$00000040 constant GPION_S_GPION_OTYPER_OT6                         \ Port x configuration I/O pin y
$00000080 constant GPION_S_GPION_OTYPER_OT7                         \ Port x configuration I/O pin y
$00000100 constant GPION_S_GPION_OTYPER_OT8                         \ Port x configuration I/O pin y
$00000200 constant GPION_S_GPION_OTYPER_OT9                         \ Port x configuration I/O pin y
$00000400 constant GPION_S_GPION_OTYPER_OT10                        \ Port x configuration I/O pin y
$00000800 constant GPION_S_GPION_OTYPER_OT11                        \ Port x configuration I/O pin y
$00001000 constant GPION_S_GPION_OTYPER_OT12                        \ Port x configuration I/O pin y
$00002000 constant GPION_S_GPION_OTYPER_OT13                        \ Port x configuration I/O pin y
$00004000 constant GPION_S_GPION_OTYPER_OT14                        \ Port x configuration I/O pin y
$00008000 constant GPION_S_GPION_OTYPER_OT15                        \ Port x configuration I/O pin y


\
\ @brief GPIO port N output speed register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000003 constant GPION_S_GPION_OSPEEDR_OSPEED0                    \ Port x configuration I/O pin y
$0000000c constant GPION_S_GPION_OSPEEDR_OSPEED1                    \ Port x configuration I/O pin y
$00000030 constant GPION_S_GPION_OSPEEDR_OSPEED2                    \ Port x configuration I/O pin y
$000000c0 constant GPION_S_GPION_OSPEEDR_OSPEED3                    \ Port x configuration I/O pin y
$00000300 constant GPION_S_GPION_OSPEEDR_OSPEED4                    \ Port x configuration I/O pin y
$00000c00 constant GPION_S_GPION_OSPEEDR_OSPEED5                    \ Port x configuration I/O pin y
$00003000 constant GPION_S_GPION_OSPEEDR_OSPEED6                    \ Port x configuration I/O pin y
$0000c000 constant GPION_S_GPION_OSPEEDR_OSPEED7                    \ Port x configuration I/O pin y
$00030000 constant GPION_S_GPION_OSPEEDR_OSPEED8                    \ Port x configuration I/O pin y
$000c0000 constant GPION_S_GPION_OSPEEDR_OSPEED9                    \ Port x configuration I/O pin y
$00300000 constant GPION_S_GPION_OSPEEDR_OSPEED10                   \ Port x configuration I/O pin y
$00c00000 constant GPION_S_GPION_OSPEEDR_OSPEED11                   \ Port x configuration I/O pin y
$03000000 constant GPION_S_GPION_OSPEEDR_OSPEED12                   \ Port x configuration I/O pin y
$0c000000 constant GPION_S_GPION_OSPEEDR_OSPEED13                   \ Port x configuration I/O pin y
$30000000 constant GPION_S_GPION_OSPEEDR_OSPEED14                   \ Port x configuration I/O pin y
$c0000000 constant GPION_S_GPION_OSPEEDR_OSPEED15                   \ Port x configuration I/O pin y


\
\ @brief GPIO port N pull-up/pull-down register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000003 constant GPION_S_GPION_PUPDR_PUPD0                        \ Port x configuration I/O pin y
$0000000c constant GPION_S_GPION_PUPDR_PUPD1                        \ Port x configuration I/O pin y
$00000030 constant GPION_S_GPION_PUPDR_PUPD2                        \ Port x configuration I/O pin y
$000000c0 constant GPION_S_GPION_PUPDR_PUPD3                        \ Port x configuration I/O pin y
$00000300 constant GPION_S_GPION_PUPDR_PUPD4                        \ Port x configuration I/O pin y
$00000c00 constant GPION_S_GPION_PUPDR_PUPD5                        \ Port x configuration I/O pin y
$00003000 constant GPION_S_GPION_PUPDR_PUPD6                        \ Port x configuration I/O pin y
$0000c000 constant GPION_S_GPION_PUPDR_PUPD7                        \ Port x configuration I/O pin y
$00030000 constant GPION_S_GPION_PUPDR_PUPD8                        \ Port x configuration I/O pin y
$000c0000 constant GPION_S_GPION_PUPDR_PUPD9                        \ Port x configuration I/O pin y
$00300000 constant GPION_S_GPION_PUPDR_PUPD10                       \ Port x configuration I/O pin y
$00c00000 constant GPION_S_GPION_PUPDR_PUPD11                       \ Port x configuration I/O pin y
$03000000 constant GPION_S_GPION_PUPDR_PUPD12                       \ Port x configuration I/O pin y
$0c000000 constant GPION_S_GPION_PUPDR_PUPD13                       \ Port x configuration I/O pin y
$30000000 constant GPION_S_GPION_PUPDR_PUPD14                       \ Port x configuration I/O pin y
$c0000000 constant GPION_S_GPION_PUPDR_PUPD15                       \ Port x configuration I/O pin y


\
\ @brief GPIO port N input data register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant GPION_S_GPION_IDR_ID0                            \ Port x input data I/O pin y
$00000002 constant GPION_S_GPION_IDR_ID1                            \ Port x input data I/O pin y
$00000004 constant GPION_S_GPION_IDR_ID2                            \ Port x input data I/O pin y
$00000008 constant GPION_S_GPION_IDR_ID3                            \ Port x input data I/O pin y
$00000010 constant GPION_S_GPION_IDR_ID4                            \ Port x input data I/O pin y
$00000020 constant GPION_S_GPION_IDR_ID5                            \ Port x input data I/O pin y
$00000040 constant GPION_S_GPION_IDR_ID6                            \ Port x input data I/O pin y
$00000080 constant GPION_S_GPION_IDR_ID7                            \ Port x input data I/O pin y
$00000100 constant GPION_S_GPION_IDR_ID8                            \ Port x input data I/O pin y
$00000200 constant GPION_S_GPION_IDR_ID9                            \ Port x input data I/O pin y
$00000400 constant GPION_S_GPION_IDR_ID10                           \ Port x input data I/O pin y
$00000800 constant GPION_S_GPION_IDR_ID11                           \ Port x input data I/O pin y
$00001000 constant GPION_S_GPION_IDR_ID12                           \ Port x input data I/O pin y
$00002000 constant GPION_S_GPION_IDR_ID13                           \ Port x input data I/O pin y
$00004000 constant GPION_S_GPION_IDR_ID14                           \ Port x input data I/O pin y
$00008000 constant GPION_S_GPION_IDR_ID15                           \ Port x input data I/O pin y


\
\ @brief GPIO port N output data register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant GPION_S_GPION_ODR_OD0                            \ Port x output data I/O pin y
$00000002 constant GPION_S_GPION_ODR_OD1                            \ Port x output data I/O pin y
$00000004 constant GPION_S_GPION_ODR_OD2                            \ Port x output data I/O pin y
$00000008 constant GPION_S_GPION_ODR_OD3                            \ Port x output data I/O pin y
$00000010 constant GPION_S_GPION_ODR_OD4                            \ Port x output data I/O pin y
$00000020 constant GPION_S_GPION_ODR_OD5                            \ Port x output data I/O pin y
$00000040 constant GPION_S_GPION_ODR_OD6                            \ Port x output data I/O pin y
$00000080 constant GPION_S_GPION_ODR_OD7                            \ Port x output data I/O pin y
$00000100 constant GPION_S_GPION_ODR_OD8                            \ Port x output data I/O pin y
$00000200 constant GPION_S_GPION_ODR_OD9                            \ Port x output data I/O pin y
$00000400 constant GPION_S_GPION_ODR_OD10                           \ Port x output data I/O pin y
$00000800 constant GPION_S_GPION_ODR_OD11                           \ Port x output data I/O pin y
$00001000 constant GPION_S_GPION_ODR_OD12                           \ Port x output data I/O pin y
$00002000 constant GPION_S_GPION_ODR_OD13                           \ Port x output data I/O pin y
$00004000 constant GPION_S_GPION_ODR_OD14                           \ Port x output data I/O pin y
$00008000 constant GPION_S_GPION_ODR_OD15                           \ Port x output data I/O pin y


\
\ @brief GPIO port N bit set/reset register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant GPION_S_GPION_BSRR_BS0                           \ Port x set I/O pin y
$00000002 constant GPION_S_GPION_BSRR_BS1                           \ Port x set I/O pin y
$00000004 constant GPION_S_GPION_BSRR_BS2                           \ Port x set I/O pin y
$00000008 constant GPION_S_GPION_BSRR_BS3                           \ Port x set I/O pin y
$00000010 constant GPION_S_GPION_BSRR_BS4                           \ Port x set I/O pin y
$00000020 constant GPION_S_GPION_BSRR_BS5                           \ Port x set I/O pin y
$00000040 constant GPION_S_GPION_BSRR_BS6                           \ Port x set I/O pin y
$00000080 constant GPION_S_GPION_BSRR_BS7                           \ Port x set I/O pin y
$00000100 constant GPION_S_GPION_BSRR_BS8                           \ Port x set I/O pin y
$00000200 constant GPION_S_GPION_BSRR_BS9                           \ Port x set I/O pin y
$00000400 constant GPION_S_GPION_BSRR_BS10                          \ Port x set I/O pin y
$00000800 constant GPION_S_GPION_BSRR_BS11                          \ Port x set I/O pin y
$00001000 constant GPION_S_GPION_BSRR_BS12                          \ Port x set I/O pin y
$00002000 constant GPION_S_GPION_BSRR_BS13                          \ Port x set I/O pin y
$00004000 constant GPION_S_GPION_BSRR_BS14                          \ Port x set I/O pin y
$00008000 constant GPION_S_GPION_BSRR_BS15                          \ Port x set I/O pin y
$00010000 constant GPION_S_GPION_BSRR_BR0                           \ Port x reset I/O pin y
$00020000 constant GPION_S_GPION_BSRR_BR1                           \ Port x reset I/O pin y
$00040000 constant GPION_S_GPION_BSRR_BR2                           \ Port x reset I/O pin y
$00080000 constant GPION_S_GPION_BSRR_BR3                           \ Port x reset I/O pin y
$00100000 constant GPION_S_GPION_BSRR_BR4                           \ Port x reset I/O pin y
$00200000 constant GPION_S_GPION_BSRR_BR5                           \ Port x reset I/O pin y
$00400000 constant GPION_S_GPION_BSRR_BR6                           \ Port x reset I/O pin y
$00800000 constant GPION_S_GPION_BSRR_BR7                           \ Port x reset I/O pin y
$01000000 constant GPION_S_GPION_BSRR_BR8                           \ Port x reset I/O pin y
$02000000 constant GPION_S_GPION_BSRR_BR9                           \ Port x reset I/O pin y
$04000000 constant GPION_S_GPION_BSRR_BR10                          \ Port x reset I/O pin y
$08000000 constant GPION_S_GPION_BSRR_BR11                          \ Port x reset I/O pin y
$10000000 constant GPION_S_GPION_BSRR_BR12                          \ Port x reset I/O pin y
$20000000 constant GPION_S_GPION_BSRR_BR13                          \ Port x reset I/O pin y
$40000000 constant GPION_S_GPION_BSRR_BR14                          \ Port x reset I/O pin y
$80000000 constant GPION_S_GPION_BSRR_BR15                          \ Port x reset I/O pin y


\
\ @brief GPIO port N configuration lock register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant GPION_S_GPION_LCKR_LCK0                          \ Port x lock I/O pin y
$00000002 constant GPION_S_GPION_LCKR_LCK1                          \ Port x lock I/O pin y
$00000004 constant GPION_S_GPION_LCKR_LCK2                          \ Port x lock I/O pin y
$00000008 constant GPION_S_GPION_LCKR_LCK3                          \ Port x lock I/O pin y
$00000010 constant GPION_S_GPION_LCKR_LCK4                          \ Port x lock I/O pin y
$00000020 constant GPION_S_GPION_LCKR_LCK5                          \ Port x lock I/O pin y
$00000040 constant GPION_S_GPION_LCKR_LCK6                          \ Port x lock I/O pin y
$00000080 constant GPION_S_GPION_LCKR_LCK7                          \ Port x lock I/O pin y
$00000100 constant GPION_S_GPION_LCKR_LCK8                          \ Port x lock I/O pin y
$00000200 constant GPION_S_GPION_LCKR_LCK9                          \ Port x lock I/O pin y
$00000400 constant GPION_S_GPION_LCKR_LCK10                         \ Port x lock I/O pin y
$00000800 constant GPION_S_GPION_LCKR_LCK11                         \ Port x lock I/O pin y
$00001000 constant GPION_S_GPION_LCKR_LCK12                         \ Port x lock I/O pin y
$00002000 constant GPION_S_GPION_LCKR_LCK13                         \ Port x lock I/O pin y
$00004000 constant GPION_S_GPION_LCKR_LCK14                         \ Port x lock I/O pin y
$00008000 constant GPION_S_GPION_LCKR_LCK15                         \ Port x lock I/O pin y
$00010000 constant GPION_S_GPION_LCKR_LCKK                          \ Lock key


\
\ @brief GPIO port N alternate function low register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant GPION_S_GPION_AFRL_AFSEL0                        \ Alternate function selection for port x I/O pin y
$000000f0 constant GPION_S_GPION_AFRL_AFSEL1                        \ Alternate function selection for port x I/O pin y
$00000f00 constant GPION_S_GPION_AFRL_AFSEL2                        \ Alternate function selection for port x I/O pin y
$0000f000 constant GPION_S_GPION_AFRL_AFSEL3                        \ Alternate function selection for port x I/O pin y
$000f0000 constant GPION_S_GPION_AFRL_AFSEL4                        \ Alternate function selection for port x I/O pin y
$00f00000 constant GPION_S_GPION_AFRL_AFSEL5                        \ Alternate function selection for port x I/O pin y
$0f000000 constant GPION_S_GPION_AFRL_AFSEL6                        \ Alternate function selection for port x I/O pin y
$f0000000 constant GPION_S_GPION_AFRL_AFSEL7                        \ Alternate function selection for port x I/O pin y


\
\ @brief GPIO port N alternate function high register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000000f constant GPION_S_GPION_AFRH_AFSEL8                        \ Alternate function selection for port x I/O pin y
$000000f0 constant GPION_S_GPION_AFRH_AFSEL9                        \ Alternate function selection for port x I/O pin y
$00000f00 constant GPION_S_GPION_AFRH_AFSEL10                       \ Alternate function selection for port x I/O pin y
$0000f000 constant GPION_S_GPION_AFRH_AFSEL11                       \ Alternate function selection for port x I/O pin y
$000f0000 constant GPION_S_GPION_AFRH_AFSEL12                       \ Alternate function selection for port x I/O pin y
$00f00000 constant GPION_S_GPION_AFRH_AFSEL13                       \ Alternate function selection for port x I/O pin y
$0f000000 constant GPION_S_GPION_AFRH_AFSEL14                       \ Alternate function selection for port x I/O pin y
$f0000000 constant GPION_S_GPION_AFRH_AFSEL15                       \ Alternate function selection for port x I/O pin y


\
\ @brief GPIO port N bit reset register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant GPION_S_GPION_BRR_BR0                            \ Port x reset IO pin y
$00000002 constant GPION_S_GPION_BRR_BR1                            \ Port x reset IO pin y
$00000004 constant GPION_S_GPION_BRR_BR2                            \ Port x reset IO pin y
$00000008 constant GPION_S_GPION_BRR_BR3                            \ Port x reset IO pin y
$00000010 constant GPION_S_GPION_BRR_BR4                            \ Port x reset IO pin y
$00000020 constant GPION_S_GPION_BRR_BR5                            \ Port x reset IO pin y
$00000040 constant GPION_S_GPION_BRR_BR6                            \ Port x reset IO pin y
$00000080 constant GPION_S_GPION_BRR_BR7                            \ Port x reset IO pin y
$00000100 constant GPION_S_GPION_BRR_BR8                            \ Port x reset IO pin y
$00000200 constant GPION_S_GPION_BRR_BR9                            \ Port x reset IO pin y
$00000400 constant GPION_S_GPION_BRR_BR10                           \ Port x reset IO pin y
$00000800 constant GPION_S_GPION_BRR_BR11                           \ Port x reset IO pin y
$00001000 constant GPION_S_GPION_BRR_BR12                           \ Port x reset IO pin y
$00002000 constant GPION_S_GPION_BRR_BR13                           \ Port x reset IO pin y
$00004000 constant GPION_S_GPION_BRR_BR14                           \ Port x reset IO pin y
$00008000 constant GPION_S_GPION_BRR_BR15                           \ Port x reset IO pin y


\
\ @brief GPIO port N secure configuration register
\ Address offset: 0x30
\ Reset value: 0x0000FFFF
\

$00000001 constant GPION_S_GPION_SECCFGR_SEC0                       \ I/O pin y of Port x security configuration
$00000002 constant GPION_S_GPION_SECCFGR_SEC1                       \ I/O pin y of Port x security configuration
$00000004 constant GPION_S_GPION_SECCFGR_SEC2                       \ I/O pin y of Port x security configuration
$00000008 constant GPION_S_GPION_SECCFGR_SEC3                       \ I/O pin y of Port x security configuration
$00000010 constant GPION_S_GPION_SECCFGR_SEC4                       \ I/O pin y of Port x security configuration
$00000020 constant GPION_S_GPION_SECCFGR_SEC5                       \ I/O pin y of Port x security configuration
$00000040 constant GPION_S_GPION_SECCFGR_SEC6                       \ I/O pin y of Port x security configuration
$00000080 constant GPION_S_GPION_SECCFGR_SEC7                       \ I/O pin y of Port x security configuration
$00000100 constant GPION_S_GPION_SECCFGR_SEC8                       \ I/O pin y of Port x security configuration
$00000200 constant GPION_S_GPION_SECCFGR_SEC9                       \ I/O pin y of Port x security configuration
$00000400 constant GPION_S_GPION_SECCFGR_SEC10                      \ I/O pin y of Port x security configuration
$00000800 constant GPION_S_GPION_SECCFGR_SEC11                      \ I/O pin y of Port x security configuration
$00001000 constant GPION_S_GPION_SECCFGR_SEC12                      \ I/O pin y of Port x security configuration
$00002000 constant GPION_S_GPION_SECCFGR_SEC13                      \ I/O pin y of Port x security configuration
$00004000 constant GPION_S_GPION_SECCFGR_SEC14                      \ I/O pin y of Port x security configuration
$00008000 constant GPION_S_GPION_SECCFGR_SEC15                      \ I/O pin y of Port x security configuration


\
\ @brief GPIO port N privileged configuration register
\ Address offset: 0x34
\ Reset value: 0x0000FFFF
\

$00000001 constant GPION_S_GPION_PRIVCFGR_PRIV0                     \ I/O pin y of Port x privilege configuration
$00000002 constant GPION_S_GPION_PRIVCFGR_PRIV1                     \ I/O pin y of Port x privilege configuration
$00000004 constant GPION_S_GPION_PRIVCFGR_PRIV2                     \ I/O pin y of Port x privilege configuration
$00000008 constant GPION_S_GPION_PRIVCFGR_PRIV3                     \ I/O pin y of Port x privilege configuration
$00000010 constant GPION_S_GPION_PRIVCFGR_PRIV4                     \ I/O pin y of Port x privilege configuration
$00000020 constant GPION_S_GPION_PRIVCFGR_PRIV5                     \ I/O pin y of Port x privilege configuration
$00000040 constant GPION_S_GPION_PRIVCFGR_PRIV6                     \ I/O pin y of Port x privilege configuration
$00000080 constant GPION_S_GPION_PRIVCFGR_PRIV7                     \ I/O pin y of Port x privilege configuration
$00000100 constant GPION_S_GPION_PRIVCFGR_PRIV8                     \ I/O pin y of Port x privilege configuration
$00000200 constant GPION_S_GPION_PRIVCFGR_PRIV9                     \ I/O pin y of Port x privilege configuration
$00000400 constant GPION_S_GPION_PRIVCFGR_PRIV10                    \ I/O pin y of Port x privilege configuration
$00000800 constant GPION_S_GPION_PRIVCFGR_PRIV11                    \ I/O pin y of Port x privilege configuration
$00001000 constant GPION_S_GPION_PRIVCFGR_PRIV12                    \ I/O pin y of Port x privilege configuration
$00002000 constant GPION_S_GPION_PRIVCFGR_PRIV13                    \ I/O pin y of Port x privilege configuration
$00004000 constant GPION_S_GPION_PRIVCFGR_PRIV14                    \ I/O pin y of Port x privilege configuration
$00008000 constant GPION_S_GPION_PRIVCFGR_PRIV15                    \ I/O pin y of Port x privilege configuration


\
\ @brief GPIO port N resource configuration lock register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant GPION_S_GPION_RCFGLOCKR_RLOCK0                   \ I/O pin y of port x resource lock
$00000002 constant GPION_S_GPION_RCFGLOCKR_RLOCK1                   \ I/O pin y of port x resource lock
$00000004 constant GPION_S_GPION_RCFGLOCKR_RLOCK2                   \ I/O pin y of port x resource lock
$00000008 constant GPION_S_GPION_RCFGLOCKR_RLOCK3                   \ I/O pin y of port x resource lock
$00000010 constant GPION_S_GPION_RCFGLOCKR_RLOCK4                   \ I/O pin y of port x resource lock
$00000020 constant GPION_S_GPION_RCFGLOCKR_RLOCK5                   \ I/O pin y of port x resource lock
$00000040 constant GPION_S_GPION_RCFGLOCKR_RLOCK6                   \ I/O pin y of port x resource lock
$00000080 constant GPION_S_GPION_RCFGLOCKR_RLOCK7                   \ I/O pin y of port x resource lock
$00000100 constant GPION_S_GPION_RCFGLOCKR_RLOCK8                   \ I/O pin y of port x resource lock
$00000200 constant GPION_S_GPION_RCFGLOCKR_RLOCK9                   \ I/O pin y of port x resource lock
$00000400 constant GPION_S_GPION_RCFGLOCKR_RLOCK10                  \ I/O pin y of port x resource lock
$00000800 constant GPION_S_GPION_RCFGLOCKR_RLOCK11                  \ I/O pin y of port x resource lock
$00001000 constant GPION_S_GPION_RCFGLOCKR_RLOCK12                  \ I/O pin y of port x resource lock
$00002000 constant GPION_S_GPION_RCFGLOCKR_RLOCK13                  \ I/O pin y of port x resource lock
$00004000 constant GPION_S_GPION_RCFGLOCKR_RLOCK14                  \ I/O pin y of port x resource lock
$00008000 constant GPION_S_GPION_RCFGLOCKR_RLOCK15                  \ I/O pin y of port x resource lock


\
\ @brief GPIO port N delay low register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000000f constant GPION_S_GPION_DELAYRL_DELAY0                     \ Port x IO pin y delay setup
$000000f0 constant GPION_S_GPION_DELAYRL_DELAY1                     \ Port x IO pin y delay setup
$00000f00 constant GPION_S_GPION_DELAYRL_DELAY2                     \ Port x IO pin y delay setup
$0000f000 constant GPION_S_GPION_DELAYRL_DELAY3                     \ Port x IO pin y delay setup
$000f0000 constant GPION_S_GPION_DELAYRL_DELAY4                     \ Port x IO pin y delay setup
$00f00000 constant GPION_S_GPION_DELAYRL_DELAY5                     \ Port x IO pin y delay setup
$0f000000 constant GPION_S_GPION_DELAYRL_DELAY6                     \ Port x IO pin y delay setup
$f0000000 constant GPION_S_GPION_DELAYRL_DELAY7                     \ Port x IO pin y delay setup


\
\ @brief GPIO port N delay high register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000000f constant GPION_S_GPION_DELAYRH_DELAY8                     \ Port x I/O pin y delay setup
$000000f0 constant GPION_S_GPION_DELAYRH_DELAY9                     \ Port x I/O pin y delay setup
$00000f00 constant GPION_S_GPION_DELAYRH_DELAY10                    \ Port x I/O pin y delay setup
$0000f000 constant GPION_S_GPION_DELAYRH_DELAY11                    \ Port x I/O pin y delay setup
$000f0000 constant GPION_S_GPION_DELAYRH_DELAY12                    \ Port x I/O pin y delay setup
$00f00000 constant GPION_S_GPION_DELAYRH_DELAY13                    \ Port x I/O pin y delay setup
$0f000000 constant GPION_S_GPION_DELAYRH_DELAY14                    \ Port x I/O pin y delay setup
$f0000000 constant GPION_S_GPION_DELAYRH_DELAY15                    \ Port x I/O pin y delay setup


\
\ @brief GPIO port N PIO control low register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000000f constant GPION_S_GPION_PIOCFGRL_PIOCFG0                   \ Port x I/O pin y configuration
$000000f0 constant GPION_S_GPION_PIOCFGRL_PIOCFG1                   \ Port x I/O pin y configuration
$00000f00 constant GPION_S_GPION_PIOCFGRL_PIOCFG2                   \ Port x I/O pin y configuration
$0000f000 constant GPION_S_GPION_PIOCFGRL_PIOCFG3                   \ Port x I/O pin y configuration
$000f0000 constant GPION_S_GPION_PIOCFGRL_PIOCFG4                   \ Port x I/O pin y configuration
$00f00000 constant GPION_S_GPION_PIOCFGRL_PIOCFG5                   \ Port x I/O pin y configuration
$0f000000 constant GPION_S_GPION_PIOCFGRL_PIOCFG6                   \ Port x I/O pin y configuration
$f0000000 constant GPION_S_GPION_PIOCFGRL_PIOCFG7                   \ Port x I/O pin y configuration


\
\ @brief GPIO port N PIO control high register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000000f constant GPION_S_GPION_PIOCFGRH_PIOCFG8                   \ Port x I/O pin y configuration
$000000f0 constant GPION_S_GPION_PIOCFGRH_PIOCFG9                   \ Port x I/O pin y configuration
$00000f00 constant GPION_S_GPION_PIOCFGRH_PIOCFG10                  \ Port x I/O pin y configuration
$0000f000 constant GPION_S_GPION_PIOCFGRH_PIOCFG11                  \ Port x I/O pin y configuration
$000f0000 constant GPION_S_GPION_PIOCFGRH_PIOCFG12                  \ Port x I/O pin y configuration
$00f00000 constant GPION_S_GPION_PIOCFGRH_PIOCFG13                  \ Port x I/O pin y configuration
$0f000000 constant GPION_S_GPION_PIOCFGRH_PIOCFG14                  \ Port x I/O pin y configuration
$f0000000 constant GPION_S_GPION_PIOCFGRH_PIOCFG15                  \ Port x I/O pin y configuration


\
\ @brief GPIO port N hardware configuration register 10
\ Address offset: 0x3C8
\ Reset value: 0x00011140
\

$0000000f constant GPION_S_GPION_HWCFGR10_AHB_IOP                   \ Bus interface selection
$000000f0 constant GPION_S_GPION_HWCFGR10_AFSIZE_CFG                \ Number of AF available for each I/O (accepted value: 1 to 4)
$00000f00 constant GPION_S_GPION_HWCFGR10_SPEED_CFG                 \ Number of speed lines for each I/O
$0000f000 constant GPION_S_GPION_HWCFGR10_LOCK_CFG                  \ Lock mechanism activation
$000f0000 constant GPION_S_GPION_HWCFGR10_SEC_CFG                   \ Security activation
$00f00000 constant GPION_S_GPION_HWCFGR10_OR_CFG                    \ Option register configuration


\
\ @brief GPIO port N hardware configuration register 9
\ Address offset: 0x3CC
\ Reset value: 0x00001FFF
\

$0000ffff constant GPION_S_GPION_HWCFGR9_EN_IO                      \ Presence granularity, each bit indicate the I/O presence


\
\ @brief GPIO port N hardware configuration register 8
\ Address offset: 0x3D0
\ Reset value: 0xFFF99999
\

$0000000f constant GPION_S_GPION_HWCFGR8_FAST_AF_IO8                \ Indicate which is the fastest AF for I/Oy (0 to F)
$000000f0 constant GPION_S_GPION_HWCFGR8_FAST_AF_IO9                \ Indicate which is the fastest AF for I/Oy (0 to F)
$00000f00 constant GPION_S_GPION_HWCFGR8_FAST_AF_IO10               \ Indicate which is the fastest AF for I/Oy (0 to F)
$0000f000 constant GPION_S_GPION_HWCFGR8_FAST_AF_IO11               \ Indicate which is the fastest AF for I/Oy (0 to F)
$000f0000 constant GPION_S_GPION_HWCFGR8_FAST_AF_IO12               \ Indicate which is the fastest AF for I/Oy (0 to F)
$00f00000 constant GPION_S_GPION_HWCFGR8_FAST_AF_IO13               \ Indicate which is the fastest AF for I/Oy (0 to F)
$0f000000 constant GPION_S_GPION_HWCFGR8_FAST_AF_IO14               \ Indicate which is the fastest AF for I/Oy (0 to F)
$f0000000 constant GPION_S_GPION_HWCFGR8_FAST_AF_IO15               \ Indicate which is the fastest AF for I/Oy (0 to F)


\
\ @brief GPIO port N hardware configuration register 7
\ Address offset: 0x3D4
\ Reset value: 0x99999999
\

$0000000f constant GPION_S_GPION_HWCFGR7_FAST_AF_IO0                \ Indicate which is the fastest AF for I/Oy (0 to F)
$000000f0 constant GPION_S_GPION_HWCFGR7_FAST_AF_IO1                \ Indicate which is the fastest AF for I/Oy (0 to F)
$00000f00 constant GPION_S_GPION_HWCFGR7_FAST_AF_IO2                \ Indicate which is the fastest AF for I/Oy (0 to F)
$0000f000 constant GPION_S_GPION_HWCFGR7_FAST_AF_IO3                \ Indicate which is the fastest AF for I/Oy (0 to F)
$000f0000 constant GPION_S_GPION_HWCFGR7_FAST_AF_IO4                \ Indicate which is the fastest AF for I/Oy (0 to F)
$00f00000 constant GPION_S_GPION_HWCFGR7_FAST_AF_IO5                \ Indicate which is the fastest AF for I/Oy (0 to F)
$0f000000 constant GPION_S_GPION_HWCFGR7_FAST_AF_IO6                \ Indicate which is the fastest AF for I/Oy (0 to F)
$f0000000 constant GPION_S_GPION_HWCFGR7_FAST_AF_IO7                \ Indicate which is the fastest AF for I/Oy (0 to F)


\
\ @brief GPIO port N hardware configuration register 6
\ Address offset: 0x3D8
\ Reset value: 0xFFFFFFFF
\

$00000000 constant GPION_S_GPION_HWCFGR6_MODER_RES                  \ MODER register reset value


\
\ @brief GPIO port N hardware configuration register 5
\ Address offset: 0x3DC
\ Reset value: 0x00000000
\

$00000000 constant GPION_S_GPION_HWCFGR5_PUPDR_RES                  \ Pull-up/pull-down register reset value


\
\ @brief GPIO port N hardware configuration register 4
\ Address offset: 0x3E0
\ Reset value: 0x00000000
\

$00000000 constant GPION_S_GPION_HWCFGR4_OSPEED_RES                 \ OSPEED register reset value


\
\ @brief GPIO port N hardware configuration register 3
\ Address offset: 0x3E4
\ Reset value: 0x00000000
\

$0000ffff constant GPION_S_GPION_HWCFGR3_ODR_RES                    \ Output data register reset value
$ffff0000 constant GPION_S_GPION_HWCFGR3_OTYPER_RES                 \ Output type register reset value


\
\ @brief GPIO port N hardware configuration register 2
\ Address offset: 0x3E8
\ Reset value: 0x00000000
\

$00000000 constant GPION_S_GPION_HWCFGR2_AFRL_RES                   \ AF register low reset value


\
\ @brief GPIO port N hardware configuration register 1
\ Address offset: 0x3EC
\ Reset value: 0x00000000
\

$00000000 constant GPION_S_GPION_HWCFGR1_AFRH_RES                   \ AF register high reset value


\
\ @brief GPIO port N hardware configuration register 0
\ Address offset: 0x3F0
\ Reset value: 0x00000000
\

$0000ffff constant GPION_S_GPION_HWCFGR0_OR_RES                     \ Option register reset value


\
\ @brief GPIO port N version register
\ Address offset: 0x3F4
\ Reset value: 0x00000010
\

$0000000f constant GPION_S_GPION_VERR_MINREV                        \ GPIO minor revision
$000000f0 constant GPION_S_GPION_VERR_MAJREV                        \ GPIO major revision


\
\ @brief GPIO port N identification register
\ Address offset: 0x3F8
\ Reset value: 0x000F0004
\

$00000000 constant GPION_S_GPION_IPIDR_IPID                         \ GPIO identifier


\
\ @brief GPIO port N size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant GPION_S_GPION_SIDR_SID                           \ Size of the memory region allocated to GPIO registers


\
\ @brief General-purpose I/Os
\
$56023400 constant GPION_S_GPION_MODER  \ offset: 0x00 : GPIO port N mode register
$56023404 constant GPION_S_GPION_OTYPER  \ offset: 0x04 : GPIO port N output type register
$56023408 constant GPION_S_GPION_OSPEEDR  \ offset: 0x08 : GPIO port N output speed register
$5602340c constant GPION_S_GPION_PUPDR  \ offset: 0x0C : GPIO port N pull-up/pull-down register
$56023410 constant GPION_S_GPION_IDR  \ offset: 0x10 : GPIO port N input data register
$56023414 constant GPION_S_GPION_ODR  \ offset: 0x14 : GPIO port N output data register
$56023418 constant GPION_S_GPION_BSRR  \ offset: 0x18 : GPIO port N bit set/reset register
$5602341c constant GPION_S_GPION_LCKR  \ offset: 0x1C : GPIO port N configuration lock register
$56023420 constant GPION_S_GPION_AFRL  \ offset: 0x20 : GPIO port N alternate function low register
$56023424 constant GPION_S_GPION_AFRH  \ offset: 0x24 : GPIO port N alternate function high register
$56023428 constant GPION_S_GPION_BRR  \ offset: 0x28 : GPIO port N bit reset register
$56023430 constant GPION_S_GPION_SECCFGR  \ offset: 0x30 : GPIO port N secure configuration register
$56023434 constant GPION_S_GPION_PRIVCFGR  \ offset: 0x34 : GPIO port N privileged configuration register
$56023438 constant GPION_S_GPION_RCFGLOCKR  \ offset: 0x38 : GPIO port N resource configuration lock register
$56023440 constant GPION_S_GPION_DELAYRL  \ offset: 0x40 : GPIO port N delay low register
$56023444 constant GPION_S_GPION_DELAYRH  \ offset: 0x44 : GPIO port N delay high register
$56023448 constant GPION_S_GPION_PIOCFGRL  \ offset: 0x48 : GPIO port N PIO control low register
$5602344c constant GPION_S_GPION_PIOCFGRH  \ offset: 0x4C : GPIO port N PIO control high register
$560237c8 constant GPION_S_GPION_HWCFGR10  \ offset: 0x3C8 : GPIO port N hardware configuration register 10
$560237cc constant GPION_S_GPION_HWCFGR9  \ offset: 0x3CC : GPIO port N hardware configuration register 9
$560237d0 constant GPION_S_GPION_HWCFGR8  \ offset: 0x3D0 : GPIO port N hardware configuration register 8
$560237d4 constant GPION_S_GPION_HWCFGR7  \ offset: 0x3D4 : GPIO port N hardware configuration register 7
$560237d8 constant GPION_S_GPION_HWCFGR6  \ offset: 0x3D8 : GPIO port N hardware configuration register 6
$560237dc constant GPION_S_GPION_HWCFGR5  \ offset: 0x3DC : GPIO port N hardware configuration register 5
$560237e0 constant GPION_S_GPION_HWCFGR4  \ offset: 0x3E0 : GPIO port N hardware configuration register 4
$560237e4 constant GPION_S_GPION_HWCFGR3  \ offset: 0x3E4 : GPIO port N hardware configuration register 3
$560237e8 constant GPION_S_GPION_HWCFGR2  \ offset: 0x3E8 : GPIO port N hardware configuration register 2
$560237ec constant GPION_S_GPION_HWCFGR1  \ offset: 0x3EC : GPIO port N hardware configuration register 1
$560237f0 constant GPION_S_GPION_HWCFGR0  \ offset: 0x3F0 : GPIO port N hardware configuration register 0
$560237f4 constant GPION_S_GPION_VERR  \ offset: 0x3F4 : GPIO port N version register
$560237f8 constant GPION_S_GPION_IPIDR  \ offset: 0x3F8 : GPIO port N identification register
$560237fc constant GPION_S_GPION_SIDR  \ offset: 0x3FC : GPIO port N size identification register

