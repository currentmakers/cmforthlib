\
\ @file lptim3.fs
\ @brief LPTIMER3 global interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief LPTIM interrupt and status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LPTIM3_LPTIM_ISR_CMPM                            \ Compare match The CMPM bit is set by hardware to inform application that LPTIM_CNT register value reached the LPTIM_CMP registerâs value.
$00000002 constant LPTIM3_LPTIM_ISR_ARRM                            \ Autoreload match ARRM is set by hardware to inform application that LPTIM_CNT registerâs value reached the LPTIM_ARR registerâs value. ARRM flag can be cleared by writing 1 to the ARRMCF bit in the LPTIM_ICR register.
$00000004 constant LPTIM3_LPTIM_ISR_EXTTRIG                         \ External trigger edge event EXTTRIG is set by hardware to inform application that a valid edge on the selected external trigger input has occurred. If the trigger is ignored because the timer has already started, then this flag is not set. EXTTRIG flag can be cleared by writing 1 to the EXTTRIGCF bit in the LPTIM_ICR register.
$00000008 constant LPTIM3_LPTIM_ISR_CMPOK                           \ Compare register update OK CMPOK is set by hardware to inform application that the APB bus write operation to the LPTIM_CMP register has been successfully completed.
$00000010 constant LPTIM3_LPTIM_ISR_ARROK                           \ Autoreload register update OK ARROK is set by hardware to inform application that the APB bus write operation to the LPTIM_ARR register has been successfully completed. ARROK flag can be cleared by writing 1 to the ARROKCF bit in the LPTIM_ICR register.
$00000020 constant LPTIM3_LPTIM_ISR_UP                              \ Counter direction change down to up In Encoder mode, UP bit is set by hardware to inform application that the counter direction has changed from down to up. UP flag can be cleared by writing 1 to the UPCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
$00000040 constant LPTIM3_LPTIM_ISR_DOWN                            \ Counter direction change up to down In Encoder mode, DOWN bit is set by hardware to inform application that the counter direction has changed from up to down. DOWN flag can be cleared by writing 1 to the DOWNCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .


\
\ @brief LPTIM interrupt clear register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LPTIM3_LPTIM_ICR_CMPMCF                          \ Compare match clear flag Writing 1 to this bit clears the CMPM flag in the LPTIM_ISR register
$00000002 constant LPTIM3_LPTIM_ICR_ARRMCF                          \ Autoreload match clear flag Writing 1 to this bit clears the ARRM flag in the LPTIM_ISR register
$00000004 constant LPTIM3_LPTIM_ICR_EXTTRIGCF                       \ External trigger valid edge clear flag Writing 1 to this bit clears the EXTTRIG flag in the LPTIM_ISR register
$00000008 constant LPTIM3_LPTIM_ICR_CMPOKCF                         \ Compare register update OK clear flag Writing 1 to this bit clears the CMPOK flag in the LPTIM_ISR register
$00000010 constant LPTIM3_LPTIM_ICR_ARROKCF                         \ Autoreload register update OK clear flag Writing 1 to this bit clears the ARROK flag in the LPTIM_ISR register
$00000020 constant LPTIM3_LPTIM_ICR_UPCF                            \ Direction change to UP clear flag Writing 1 to this bit clear the UP flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
$00000040 constant LPTIM3_LPTIM_ICR_DOWNCF                          \ Direction change to down clear flag Writing 1 to this bit clear the DOWN flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .


\
\ @brief LPTIM interrupt enable register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant LPTIM3_LPTIM_IER_CMPMIE                          \ Compare match Interrupt Enable
$00000002 constant LPTIM3_LPTIM_IER_ARRMIE                          \ Autoreload match Interrupt Enable
$00000004 constant LPTIM3_LPTIM_IER_EXTTRIGIE                       \ External trigger valid edge Interrupt Enable
$00000008 constant LPTIM3_LPTIM_IER_CMPOKIE                         \ Compare register update OK Interrupt Enable
$00000010 constant LPTIM3_LPTIM_IER_ARROKIE                         \ Autoreload register update OK Interrupt Enable
$00000020 constant LPTIM3_LPTIM_IER_UPIE                            \ Direction change to UP Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
$00000040 constant LPTIM3_LPTIM_IER_DOWNIE                          \ Direction change to down Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .


\
\ @brief LPTIM configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant LPTIM3_LPTIM_CFGR_CKSEL                          \ Clock selector The CKSEL bit selects which clock source the LPTIM will use:
$00000006 constant LPTIM3_LPTIM_CFGR_CKPOL                          \ Clock Polarity If LPTIM is clocked by an external clock source: When the LPTIM is clocked by an external clock source, CKPOL bits is used to configure the active edge or edges used by the counter: If the LPTIM is configured in Encoder mode (ENC bit is set), the encoder sub-mode 1 is active. If the LPTIM is configured in Encoder mode (ENC bit is set), the encoder sub-mode 2 is active. Refer to for more details about Encoder mode sub-modes.
$00000018 constant LPTIM3_LPTIM_CFGR_CKFLT                          \ Configurable digital filter for external clock The CKFLT value sets the number of consecutive equal samples that should be detected when a level change occurs on an external clock signal before it is considered as a valid level transition. An internal clock source must be present to use this feature
$000000c0 constant LPTIM3_LPTIM_CFGR_TRGFLT                         \ Configurable digital filter for trigger The TRGFLT value sets the number of consecutive equal samples that should be detected when a level change occurs on an internal trigger before it is considered as a valid level transition. An internal clock source must be present to use this feature
$00000e00 constant LPTIM3_LPTIM_CFGR_PRESC                          \ Clock prescaler The PRESC bits configure the prescaler division factor. It can be one among the following division factors:
$0000e000 constant LPTIM3_LPTIM_CFGR_TRIGSEL                        \ Trigger selector The TRIGSEL bits select the trigger source that will serve as a trigger event for the LPTIM among the below 8 available sources: See for details.
$00060000 constant LPTIM3_LPTIM_CFGR_TRIGEN                         \ Trigger enable and polarity The TRIGEN bits controls whether the LPTIM counter is started by an external trigger or not. If the external trigger option is selected, three configurations are possible for the trigger active edge:
$00080000 constant LPTIM3_LPTIM_CFGR_TIMOUT                         \ Timeout enable The TIMOUT bit controls the Timeout feature
$00100000 constant LPTIM3_LPTIM_CFGR_WAVE                           \ Waveform shape The WAVE bit controls the output shape
$00200000 constant LPTIM3_LPTIM_CFGR_WAVPOL                         \ Waveform shape polarity The WAVEPOL bit controls the output polarity
$00400000 constant LPTIM3_LPTIM_CFGR_PRELOAD                        \ Registers update mode The PRELOAD bit controls the LPTIM_ARR and the LPTIM_CMP registers update modality
$00800000 constant LPTIM3_LPTIM_CFGR_COUNTMODE                      \ counter mode enabled The COUNTMODE bit selects which clock source is used by the LPTIM to clock the counter:
$01000000 constant LPTIM3_LPTIM_CFGR_ENC                            \ Encoder mode enable The ENC bit controls the Encoder mode Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .


\
\ @brief LPTIM control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant LPTIM3_LPTIM_CR_ENABLE                           \ LPTIM enable The ENABLE bit is set and cleared by software.
$00000002 constant LPTIM3_LPTIM_CR_SNGSTRT                          \ LPTIM start in Single mode This bit is set by software and cleared by hardware. In case of software start (TRIGEN[1:0] = '00â), setting this bit starts the LPTIM in single pulse mode. If the software start is disabled (TRIGEN[1:0] different than '00â), setting this bit starts the LPTIM in single pulse mode as soon as an external trigger is detected. If this bit is set when the LPTIM is in continuous counting mode, then the LPTIM will stop at the following match between LPTIM_ARR and LPTIM_CNT registers. This bit can only be set when the LPTIM is enabled. It will be automatically reset by hardware.
$00000004 constant LPTIM3_LPTIM_CR_CNTSTRT                          \ Timer start in Continuous mode This bit is set by software and cleared by hardware. In case of software start (TRIGEN[1:0] = '00â), setting this bit starts the LPTIM in Continuous mode. If the software start is disabled (TRIGEN[1:0] different than '00â), setting this bit starts the timer in Continuous mode as soon as an external trigger is detected. If this bit is set when a single pulse mode counting is ongoing, then the timer will not stop at the next match between the LPTIM_ARR and LPTIM_CNT registers and the LPTIM counter keeps counting in Continuous mode. This bit can be set only when the LPTIM is enabled. It will be automatically reset by hardware.
$00000008 constant LPTIM3_LPTIM_CR_COUNTRST                         \ Counter reset This bit is set by software and cleared by hardware. When set to '1' this bit will trigger a synchronous reset of the LPTIM_CNT counter register. Due to the synchronous nature of this reset, it only takes place after a synchronization delay of 3 LPTimer core clock cycles (LPTimer core clock may be different from APB clock). COUNTRST must never be set to '1' by software before it is already cleared to '0' by hardware. Software should consequently check that COUNTRST bit is already cleared to '0' before attempting to set it to '1'.
$00000010 constant LPTIM3_LPTIM_CR_RSTARE                           \ Reset after read enable This bit is set and cleared by software. When RSTARE is set to '1', any read access to LPTIM_CNT register will asynchronously reset LPTIM_CNT register content.


\
\ @brief LPTIM compare register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM3_LPTIM_CMP_CMP                             \ Compare value CMP is the compare value used by the LPTIM.


\
\ @brief LPTIM autoreload register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$0000ffff constant LPTIM3_LPTIM_ARR_ARR                             \ Auto reload value ARR is the autoreload value for the LPTIM. This value must be strictly greater than the CMP[15:0] value.


\
\ @brief LPTIM counter register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM3_LPTIM_CNT_CNT                             \ Counter value When the LPTIM is running with an asynchronous clock, reading the LPTIM_CNT register may return unreliable values. So in this case it is necessary to perform two consecutive read accesses and verify that the two returned values are identical. It should be noted that for a reliable LPTIM_CNT register read access, two consecutive read accesses must be performed and compared. A read access can be considered reliable when the values of the two consecutive read accesses are equal.


\
\ @brief LPTIM configuration register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000003 constant LPTIM3_LPTIM_CFGR2_IN1SEL                        \ LPTIM input 1 selection The IN1SEL bits control the LPTIM Input 1 multiplexer, which connects LPTIM Input 1 to one of the available inputs. For connection details refer to . Note: If LPTIM does not implement external input clock, these bits are reserved. Please refer to .
$00000030 constant LPTIM3_LPTIM_CFGR2_IN2SEL                        \ LPTIM input 2 selection The IN2SEL bits control the LPTIM Input 2 multiplexer, which connect LPTIM Input 2 to one of the available inputs. For connection details refer to . Note: If the LPTIM does not support encoder mode feature, these bits are reserved. Please refer to .


\
\ @brief LPTIM peripheral version identification register
\ Address offset: 0x3F4
\ Reset value: 0x00000014
\

$0000000f constant LPTIM3_LPTIM_VERR_MINREV                         \ Minor revision This is a read only bit-field and is read as MINREV[3:0] = 4.
$000000f0 constant LPTIM3_LPTIM_VERR_MAJREV                         \ Major revision This is read only bit-field and is read as MAJREV[7:4] = 1.


\
\ @brief LPTIM peripheral type identification register
\ Address offset: 0x3F8
\ Reset value: 0x00120011
\

$00000000 constant LPTIM3_LPTIM_PIDR_P_ID                           \ Peripheral type identifier This a read only register and is always read as P_ID[31:0] = 0x00120011.


\
\ @brief LPTIM registers map size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant LPTIM3_LPTIM_SIDR_S_ID                           \ Registers map size identifier This a read only register and is always read as S_ID[31:0] = 0xA3C5DD01. This register identifies the size of the memory region allocated to the LPTIM registers. The size of this memory region is 1Â KB.


\
\ @brief LPTIMER3 global interrupt
\
$50022000 constant LPTIM3_LPTIM_ISR  \ offset: 0x00 : LPTIM interrupt and status register
$50022004 constant LPTIM3_LPTIM_ICR  \ offset: 0x04 : LPTIM interrupt clear register
$50022008 constant LPTIM3_LPTIM_IER  \ offset: 0x08 : LPTIM interrupt enable register
$5002200c constant LPTIM3_LPTIM_CFGR  \ offset: 0x0C : LPTIM configuration register
$50022010 constant LPTIM3_LPTIM_CR  \ offset: 0x10 : LPTIM control register
$50022014 constant LPTIM3_LPTIM_CMP  \ offset: 0x14 : LPTIM compare register
$50022018 constant LPTIM3_LPTIM_ARR  \ offset: 0x18 : LPTIM autoreload register
$5002201c constant LPTIM3_LPTIM_CNT  \ offset: 0x1C : LPTIM counter register
$50022024 constant LPTIM3_LPTIM_CFGR2  \ offset: 0x24 : LPTIM configuration register 2
$500223f4 constant LPTIM3_LPTIM_VERR  \ offset: 0x3F4 : LPTIM peripheral version identification register
$500223f8 constant LPTIM3_LPTIM_PIDR  \ offset: 0x3F8 : LPTIM peripheral type identification register
$500223fc constant LPTIM3_LPTIM_SIDR  \ offset: 0x3FC : LPTIM registers map size identification register

