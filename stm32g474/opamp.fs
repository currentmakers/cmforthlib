\
\ @file opamp.fs
\ @brief Operational amplifiers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief OPAMP1 control/status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant OPAMP_OPAMP1_CSR_OPAEN                           \ Operational amplifier Enable
$00000002 constant OPAMP_OPAMP1_CSR_FORCE_VP                        \ FORCE_VP
$0000000c constant OPAMP_OPAMP1_CSR_VP_SEL                          \ VP_SEL
$00000010 constant OPAMP_OPAMP1_CSR_USERTRIM                        \ USERTRIM
$00000060 constant OPAMP_OPAMP1_CSR_VM_SEL                          \ VM_SEL
$00000080 constant OPAMP_OPAMP1_CSR_OPAHSM                          \ OPAHSM
$00000100 constant OPAMP_OPAMP1_CSR_OPAINTOEN                       \ OPAINTOEN
$00000800 constant OPAMP_OPAMP1_CSR_CALON                           \ CALON
$00003000 constant OPAMP_OPAMP1_CSR_CALSEL                          \ CALSEL
$0007c000 constant OPAMP_OPAMP1_CSR_PGA_GAIN                        \ PGA_GAIN
$00f80000 constant OPAMP_OPAMP1_CSR_TRIMOFFSETP                     \ TRIMOFFSETP
$1f000000 constant OPAMP_OPAMP1_CSR_TRIMOFFSETN                     \ TRIMOFFSETN
$40000000 constant OPAMP_OPAMP1_CSR_CALOUT                          \ CALOUT
$80000000 constant OPAMP_OPAMP1_CSR_LOCK                            \ LOCK


\
\ @brief OPAMP2 control/status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant OPAMP_OPAMP2_CSR_OPAEN                           \ Operational amplifier Enable
$00000002 constant OPAMP_OPAMP2_CSR_FORCE_VP                        \ FORCE_VP
$0000000c constant OPAMP_OPAMP2_CSR_VP_SEL                          \ VP_SEL
$00000010 constant OPAMP_OPAMP2_CSR_USERTRIM                        \ USERTRIM
$00000060 constant OPAMP_OPAMP2_CSR_VM_SEL                          \ VM_SEL
$00000080 constant OPAMP_OPAMP2_CSR_OPAHSM                          \ OPAHSM
$00000100 constant OPAMP_OPAMP2_CSR_OPAINTOEN                       \ OPAINTOEN
$00000800 constant OPAMP_OPAMP2_CSR_CALON                           \ CALON
$00003000 constant OPAMP_OPAMP2_CSR_CALSEL                          \ CALSEL
$0007c000 constant OPAMP_OPAMP2_CSR_PGA_GAIN                        \ PGA_GAIN
$00f80000 constant OPAMP_OPAMP2_CSR_TRIMOFFSETP                     \ TRIMOFFSETP
$1f000000 constant OPAMP_OPAMP2_CSR_TRIMOFFSETN                     \ TRIMOFFSETN
$40000000 constant OPAMP_OPAMP2_CSR_CALOUT                          \ CALOUT
$80000000 constant OPAMP_OPAMP2_CSR_LOCK                            \ LOCK


\
\ @brief OPAMP3 control/status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant OPAMP_OPAMP3_CSR_OPAEN                           \ Operational amplifier Enable
$00000002 constant OPAMP_OPAMP3_CSR_FORCE_VP                        \ FORCE_VP
$0000000c constant OPAMP_OPAMP3_CSR_VP_SEL                          \ VP_SEL
$00000010 constant OPAMP_OPAMP3_CSR_USERTRIM                        \ USERTRIM
$00000060 constant OPAMP_OPAMP3_CSR_VM_SEL                          \ VM_SEL
$00000080 constant OPAMP_OPAMP3_CSR_OPAHSM                          \ OPAHSM
$00000100 constant OPAMP_OPAMP3_CSR_OPAINTOEN                       \ OPAINTOEN
$00000800 constant OPAMP_OPAMP3_CSR_CALON                           \ CALON
$00003000 constant OPAMP_OPAMP3_CSR_CALSEL                          \ CALSEL
$0007c000 constant OPAMP_OPAMP3_CSR_PGA_GAIN                        \ PGA_GAIN
$00f80000 constant OPAMP_OPAMP3_CSR_TRIMOFFSETP                     \ TRIMOFFSETP
$1f000000 constant OPAMP_OPAMP3_CSR_TRIMOFFSETN                     \ TRIMOFFSETN
$40000000 constant OPAMP_OPAMP3_CSR_CALOUT                          \ CALOUT
$80000000 constant OPAMP_OPAMP3_CSR_LOCK                            \ LOCK


\
\ @brief OPAMP4 control/status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant OPAMP_OPAMP4_CSR_OPAEN                           \ Operational amplifier Enable
$00000002 constant OPAMP_OPAMP4_CSR_FORCE_VP                        \ FORCE_VP
$0000000c constant OPAMP_OPAMP4_CSR_VP_SEL                          \ VP_SEL
$00000010 constant OPAMP_OPAMP4_CSR_USERTRIM                        \ USERTRIM
$00000060 constant OPAMP_OPAMP4_CSR_VM_SEL                          \ VM_SEL
$00000080 constant OPAMP_OPAMP4_CSR_OPAHSM                          \ OPAHSM
$00000100 constant OPAMP_OPAMP4_CSR_OPAINTOEN                       \ OPAINTOEN
$00000800 constant OPAMP_OPAMP4_CSR_CALON                           \ CALON
$00003000 constant OPAMP_OPAMP4_CSR_CALSEL                          \ CALSEL
$0007c000 constant OPAMP_OPAMP4_CSR_PGA_GAIN                        \ PGA_GAIN
$00f80000 constant OPAMP_OPAMP4_CSR_TRIMOFFSETP                     \ TRIMOFFSETP
$1f000000 constant OPAMP_OPAMP4_CSR_TRIMOFFSETN                     \ TRIMOFFSETN
$40000000 constant OPAMP_OPAMP4_CSR_CALOUT                          \ CALOUT
$80000000 constant OPAMP_OPAMP4_CSR_LOCK                            \ LOCK


\
\ @brief OPAMP5 control/status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant OPAMP_OPAMP5_CSR_OPAEN                           \ Operational amplifier Enable
$00000002 constant OPAMP_OPAMP5_CSR_FORCE_VP                        \ FORCE_VP
$0000000c constant OPAMP_OPAMP5_CSR_VP_SEL                          \ VP_SEL
$00000010 constant OPAMP_OPAMP5_CSR_USERTRIM                        \ USERTRIM
$00000060 constant OPAMP_OPAMP5_CSR_VM_SEL                          \ VM_SEL
$00000080 constant OPAMP_OPAMP5_CSR_OPAHSM                          \ OPAHSM
$00000100 constant OPAMP_OPAMP5_CSR_OPAINTOEN                       \ OPAINTOEN
$00000800 constant OPAMP_OPAMP5_CSR_CALON                           \ CALON
$00003000 constant OPAMP_OPAMP5_CSR_CALSEL                          \ CALSEL
$0007c000 constant OPAMP_OPAMP5_CSR_PGA_GAIN                        \ PGA_GAIN
$00f80000 constant OPAMP_OPAMP5_CSR_TRIMOFFSETP                     \ TRIMOFFSETP
$1f000000 constant OPAMP_OPAMP5_CSR_TRIMOFFSETN                     \ TRIMOFFSETN
$40000000 constant OPAMP_OPAMP5_CSR_CALOUT                          \ CALOUT
$80000000 constant OPAMP_OPAMP5_CSR_LOCK                            \ LOCK


\
\ @brief OPAMP6 control/status register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant OPAMP_OPAMP6_CSR_OPAEN                           \ Operational amplifier Enable
$00000002 constant OPAMP_OPAMP6_CSR_FORCE_VP                        \ FORCE_VP
$0000000c constant OPAMP_OPAMP6_CSR_VP_SEL                          \ VP_SEL
$00000010 constant OPAMP_OPAMP6_CSR_USERTRIM                        \ USERTRIM
$00000060 constant OPAMP_OPAMP6_CSR_VM_SEL                          \ VM_SEL
$00000080 constant OPAMP_OPAMP6_CSR_OPAHSM                          \ OPAHSM
$00000100 constant OPAMP_OPAMP6_CSR_OPAINTOEN                       \ OPAINTOEN
$00000800 constant OPAMP_OPAMP6_CSR_CALON                           \ CALON
$00003000 constant OPAMP_OPAMP6_CSR_CALSEL                          \ CALSEL
$0007c000 constant OPAMP_OPAMP6_CSR_PGA_GAIN                        \ PGA_GAIN
$00f80000 constant OPAMP_OPAMP6_CSR_TRIMOFFSETP                     \ TRIMOFFSETP
$1f000000 constant OPAMP_OPAMP6_CSR_TRIMOFFSETN                     \ TRIMOFFSETN
$40000000 constant OPAMP_OPAMP6_CSR_CALOUT                          \ CALOUT
$80000000 constant OPAMP_OPAMP6_CSR_LOCK                            \ LOCK


\
\ @brief OPAMP1 control/status register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant OPAMP_OPAMP1_TCMR_VMS_SEL                        \ VMS_SEL
$00000006 constant OPAMP_OPAMP1_TCMR_VPS_SEL                        \ VPS_SEL
$00000008 constant OPAMP_OPAMP1_TCMR_T1CM_EN                        \ T1CM_EN
$00000010 constant OPAMP_OPAMP1_TCMR_T8CM_EN                        \ T8CM_EN
$00000020 constant OPAMP_OPAMP1_TCMR_T20CM_EN                       \ T20CM_EN
$80000000 constant OPAMP_OPAMP1_TCMR_LOCK                           \ LOCK


\
\ @brief OPAMP2 control/status register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant OPAMP_OPAMP2_TCMR_VMS_SEL                        \ VMS_SEL
$00000006 constant OPAMP_OPAMP2_TCMR_VPS_SEL                        \ VPS_SEL
$00000008 constant OPAMP_OPAMP2_TCMR_T1CM_EN                        \ T1CM_EN
$00000010 constant OPAMP_OPAMP2_TCMR_T8CM_EN                        \ T8CM_EN
$00000020 constant OPAMP_OPAMP2_TCMR_T20CM_EN                       \ T20CM_EN
$80000000 constant OPAMP_OPAMP2_TCMR_LOCK                           \ LOCK


\
\ @brief OPAMP3 control/status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant OPAMP_OPAMP3_TCMR_VMS_SEL                        \ VMS_SEL
$00000006 constant OPAMP_OPAMP3_TCMR_VPS_SEL                        \ VPS_SEL
$00000008 constant OPAMP_OPAMP3_TCMR_T1CM_EN                        \ T1CM_EN
$00000010 constant OPAMP_OPAMP3_TCMR_T8CM_EN                        \ T8CM_EN
$00000020 constant OPAMP_OPAMP3_TCMR_T20CM_EN                       \ T20CM_EN
$80000000 constant OPAMP_OPAMP3_TCMR_LOCK                           \ LOCK


\
\ @brief OPAMP4 control/status register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant OPAMP_OPAMP4_TCMR_VMS_SEL                        \ VMS_SEL
$00000006 constant OPAMP_OPAMP4_TCMR_VPS_SEL                        \ VPS_SEL
$00000008 constant OPAMP_OPAMP4_TCMR_T1CM_EN                        \ T1CM_EN
$00000010 constant OPAMP_OPAMP4_TCMR_T8CM_EN                        \ T8CM_EN
$00000020 constant OPAMP_OPAMP4_TCMR_T20CM_EN                       \ T20CM_EN
$80000000 constant OPAMP_OPAMP4_TCMR_LOCK                           \ LOCK


\
\ @brief OPAMP5 control/status register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant OPAMP_OPAMP5_TCMR_VMS_SEL                        \ VMS_SEL
$00000006 constant OPAMP_OPAMP5_TCMR_VPS_SEL                        \ VPS_SEL
$00000008 constant OPAMP_OPAMP5_TCMR_T1CM_EN                        \ T1CM_EN
$00000010 constant OPAMP_OPAMP5_TCMR_T8CM_EN                        \ T8CM_EN
$00000020 constant OPAMP_OPAMP5_TCMR_T20CM_EN                       \ T20CM_EN
$80000000 constant OPAMP_OPAMP5_TCMR_LOCK                           \ LOCK


\
\ @brief OPAMP6 control/status register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant OPAMP_OPAMP6_TCMR_VMS_SEL                        \ VMS_SEL
$00000006 constant OPAMP_OPAMP6_TCMR_VPS_SEL                        \ VPS_SEL
$00000008 constant OPAMP_OPAMP6_TCMR_T1CM_EN                        \ T1CM_EN
$00000010 constant OPAMP_OPAMP6_TCMR_T8CM_EN                        \ T8CM_EN
$00000020 constant OPAMP_OPAMP6_TCMR_T20CM_EN                       \ T20CM_EN
$80000000 constant OPAMP_OPAMP6_TCMR_LOCK                           \ LOCK


\
\ @brief Operational amplifiers
\
$40010300 constant OPAMP_OPAMP1_CSR  \ offset: 0x00 : OPAMP1 control/status register
$40010304 constant OPAMP_OPAMP2_CSR  \ offset: 0x04 : OPAMP2 control/status register
$40010308 constant OPAMP_OPAMP3_CSR  \ offset: 0x08 : OPAMP3 control/status register
$4001030c constant OPAMP_OPAMP4_CSR  \ offset: 0x0C : OPAMP4 control/status register
$40010310 constant OPAMP_OPAMP5_CSR  \ offset: 0x10 : OPAMP5 control/status register
$40010314 constant OPAMP_OPAMP6_CSR  \ offset: 0x14 : OPAMP6 control/status register
$40010318 constant OPAMP_OPAMP1_TCMR  \ offset: 0x18 : OPAMP1 control/status register
$4001031c constant OPAMP_OPAMP2_TCMR  \ offset: 0x1C : OPAMP2 control/status register
$40010320 constant OPAMP_OPAMP3_TCMR  \ offset: 0x20 : OPAMP3 control/status register
$40010324 constant OPAMP_OPAMP4_TCMR  \ offset: 0x24 : OPAMP4 control/status register
$40010328 constant OPAMP_OPAMP5_TCMR  \ offset: 0x28 : OPAMP5 control/status register
$4001032c constant OPAMP_OPAMP6_TCMR  \ offset: 0x2C : OPAMP6 control/status register

